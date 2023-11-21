using cw9;

StudentsRepo repo = new StudentsRepo();

var students = repo.GetStudents();
StudentsInterface.ShowAllStudents(students);
var s = StudentsInterface.GetStudent();
repo.InsertStudent(s);
//dorobic uzytkownik pyta o nazwisko wyszukiwanie w List<Student> 
//potem potwierdzenie usuwania studenta ---> 3
// update studenta o danym nazwisku --->4
// pelna aplikacja CRUD z menu podobnie jak filmy
