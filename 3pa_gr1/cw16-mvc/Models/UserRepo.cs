namespace cw16_mvc.Models;

public class UserRepo
{
    public static List<User>? GetUsers(string path = "dane.txt")
    {
        if (!System.IO.File.Exists("dane.txt")) return null;
        var lines = System.IO.File.ReadAllLines("dane.txt");
        List<User> users = new();
        foreach(var line in lines){
            var data = line.Split(';');
            if(data.Length==4){
                users.Add(new User{
                    Firstname = data[0],
                    Lastname = data[1],
                    Age = Convert.ToInt32(data[2]),
                    Description = data[3]
                });
            }
        }

        return users;
    }
}