namespace cw15_forms.Models
{
    public class FileRepo
    {
        public static void SaveToFile(Todo todo, string path = "data.csv")
        {
            File.AppendAllText(path, todo.ToString());
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
    }
}
