using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using web1;

namespace MyApp.Namespace
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public List<Todo> Todos { get; set; }
        private RepoTodos _repo;
        public IndexModel(IConfiguration configuration)
        {
            _repo = new RepoTodos(configuration);
        }
        public void OnGet()
        {
            Todos = _repo.GetTodos();
        }
    }
}
