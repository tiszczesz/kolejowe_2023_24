using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public int A { get; set; }
        public void OnGet()
        {
            A = 3456;
            ViewData["info"] = "To jest zawarość info";
            var aa = Request.Method;
        }
        public void OnPost()
        {
            try
            {
                var result =Math.Round( Math.Sqrt(Convert.ToInt32(Request.Form["liczba"])),2);
                ViewData["liczba"] = Request.Form["liczba"];
                ViewData["result"] = result;
            }catch(FormatException ex){
                ViewData["result"] = "BŁEDNE DANE!!!";
            }
            //var elem = Request.Form;
            // var aa = Request.Method;

        }
    }
}
