
namespace cw15_forms.Models
{
    public class FileRepo
    {
        public static void SaveToFile(Todo todo, string path = "data.csv")
        {
            var trash = new string[]{todo.ToString()};
            File.AppendAllLines(path,trash);
        }
        public static List<Todo> GetAll(string path = "data.csv")
        {
            List<Todo> todos = new();
            if (File.Exists(path))
            {
                var lines = File.ReadAllLines(path);
                foreach (var line in lines)
                {
                    var todo = Todo.GetTodo(line);
                    if (todo != null) todos.Add(todo);
                }
            }
            return todos;
        }

        public static void SaveAll(List<Todo> todos,string path="data.csv")
        {
            List<string> lines = new();
            foreach(var t in todos){
                lines.Add(t.ToString());
            }
            File.WriteAllLines(path,lines);
        }
    }
}
