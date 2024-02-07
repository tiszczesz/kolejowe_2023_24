using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string? Info { get; set; }

        [BindProperty]
        public string? Result { get; set; }
        public void OnGet()
        {
            ViewData["info2"] = "Ala już kota nie ma";
            Info = "Ala ma kota";
            var request = Request;
        }
        public void OnPost(){
             var request = Request;
             var firstname = Request.Form["firstname"];
             var lastname = Request.Form["lastname"];
             Result = "witaj: "+firstname+ " "+lastname;
        }
    }
}
