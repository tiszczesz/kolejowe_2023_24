using cw15.Models;
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
            if(ModelState.IsValid){
                if(Choice=="rek"){
                    ViewData["result"] = $"Rekurencyjnie: NWD({A},{B}) = {NWD.NWDRec(A,B)}";
                }else{
                     ViewData["result"] = $"Iteracyjnie: NWD({A},{B}) = {NWD.NWDIter(A,B)}";
                }
            }else{
                ViewData["result"]="Błędne lub brak danych";
            }
            
        }
    }
}
