using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class ResultModel : PageModel
    {
        public void OnGet()
        {
        }
        public void OnPost(){
            ViewData["result"] = Request.Form["firstname"];
        }
    }
}
