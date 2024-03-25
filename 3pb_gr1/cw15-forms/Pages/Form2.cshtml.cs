using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class Form2Model : PageModel
    {
        [BindProperty]
        public int A { get; set; }

          [BindProperty]
        public int B { get; set; }
        public void OnGet()
        {
        }
         public void OnPost()
        {
            if(ModelState.IsValid){
                //tu liczycie nwd i wstawiacie do ViewData
            }
        }
    }
}
