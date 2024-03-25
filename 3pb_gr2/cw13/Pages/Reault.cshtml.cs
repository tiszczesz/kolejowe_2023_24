using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class ReaultModel : PageModel
    {
        public void OnGet()
        {
        }
        public void OnPost(){
            var result = Request;
        }
    }
}
