using cw9;

StudentsRepo repo = new StudentsRepo();

var students = repo.GetStudents();
StudentsInterface.ShowAllStudents(students);
