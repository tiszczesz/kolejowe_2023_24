using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Info { get; set; }
        public void OnGet()
        {
            Info = "ala ma kota";
        }
    }
}
