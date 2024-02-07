using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public List<string>? Todos { get; set; }
        public void OnGet()
        {
            Todos = new List<string>{
                "Wstać","Zjeść","...","wyjść"
            };
        }
    }
}
