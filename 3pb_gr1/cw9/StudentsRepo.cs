using System.Data;
using Microsoft.Data.Sqlite;

namespace cw9;

public class StudentsRepo
{
    private string connString;
    public StudentsRepo()
    {
        string path = AppContext.BaseDirectory;
        connString = "Data Source="+System.IO.Path.Join(path,"data.db");
    }
    public List<Student> GetStudents(){
        List<Student> students = new List<Student>();
        SqliteConnection conn = new SqliteConnection(connString);
        //SqliteCommand command = new SqliteCommand("zapytanie",conn);
        SqliteCommand command = conn.CreateCommand();
        command.CommandText = "SELECT * FROM Students";
        conn.Open();
        SqliteDataReader rd = command.ExecuteReader();
        if(rd.HasRows){
            while(rd.Read()){
                students.Add(
                    new Student{
                        Id = rd.GetInt32(0),
                        Firstname = rd.GetString(1),
                        Lastname = rd.GetString(2),
                        BirthDay = rd.GetDateTime(3),
                        AvgRange = rd.GetDouble(4)
                    }
                );
            }
        }


        conn.Close();
        return students;
    }
}
