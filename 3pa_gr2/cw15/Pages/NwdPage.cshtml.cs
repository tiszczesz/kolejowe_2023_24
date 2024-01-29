using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class NwdPageModel : PageModel
    {
        [BindProperty]
        public int A { get; set; }

        [BindProperty]
        public int B { get; set; }

        [BindProperty]
        public string Choice { get; set; }
        public void OnGet()
        {
           
        }
         public void OnPost()
        {
            var result = ModelState;
        }
    }
}
