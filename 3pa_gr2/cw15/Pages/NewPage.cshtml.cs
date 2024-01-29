using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class NewPageModel : PageModel
    {
        [BindProperty]
        public string? Firstname { get; set; }

        [BindProperty]
        public string? Lastname { get; set; }

        [BindProperty]
        public int? Age { get; set; }
        public void OnGet()
        {
        }
         public void OnPost()
        {
            var result = ModelState;
        }
    }
}
