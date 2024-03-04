using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace web1.Pages
{
    public class FormModel : PageModel
    {
        [BindProperty]
        public Todo  MyTodo { get; set; }
        private RepoTodos _repo;
        public FormModel(IConfiguration conf)
        {
            _repo = new RepoTodos(conf);
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost() {
            if (ModelState.IsValid)
            {
                //do bazy
                _repo.SaveTodo(MyTodo);
                return RedirectToAction("Index");
            }
            return Page();
        }
    }
}
