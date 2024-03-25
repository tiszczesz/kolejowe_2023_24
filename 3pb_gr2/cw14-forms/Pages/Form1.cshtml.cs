using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class Form1Model : PageModel
    {
        [BindProperty]
        public string Title { get; set; }

        [BindProperty]
        public string Author { get; set; }

        [BindProperty]
        public DateTime DateRel { get; set; }
        public void OnGet()
        {
        }

        public void OnPost(){
            if(ModelState.IsValid){
                ViewData["result"] = $"Tytuł: {Title} autor: {Author} "
                           + $"data: {DateRel.ToShortDateString()}";
            }else{
                ViewData["result"] = "Błędne dane!!!";
            }
        }
    }
}
