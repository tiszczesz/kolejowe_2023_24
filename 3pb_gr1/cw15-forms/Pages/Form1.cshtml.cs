using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class Form1Model : PageModel
    {
        [BindProperty]
        public string Firstname { get; set; }

        [BindProperty]
        public string Lastname { get; set; }

        [BindProperty]
        public int Age { get; set; }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                ViewData["result"] = $"Witaj {Firstname} {Lastname} wiek: {Age}, dzisiaj mamy: {DateTime.Now.ToShortDateString()} ";
            }
            else
            {
                ViewData["result"] = "Błędne dane";
            }

        }
    }
}
