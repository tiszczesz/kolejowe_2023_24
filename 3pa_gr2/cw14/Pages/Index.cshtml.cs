using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Info { get; set; } = "Ello Welllo";
        public void OnGet()
        {
            ViewData["info"] = "To jest wartość z ViewData";
            var bb = Request.Method;
           
        }
        public void OnPost(){
            // var form = Request.Form;
        } 
    }
}
