using cw15_forms.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cw15_forms.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public List<Todo> Todos { get; set; }
        public void OnGet()
        {
            Todos = FileRepo.GetAll().OrderBy(t=>t.DateOf).ToList();
        }
    }
}
