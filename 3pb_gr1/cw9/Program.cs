using cw9;

StudentsRepo repo = new StudentsRepo();

var students = repo.GetStudents();
StudentsInterface.ShowAllStudents(students);
var s = StudentsInterface.GetStudent();
repo.InsertStudent(s);
