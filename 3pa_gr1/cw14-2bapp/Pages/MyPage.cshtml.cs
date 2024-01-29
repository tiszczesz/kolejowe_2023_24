using cw14_2bapp;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    
    public class MyPageModel : PageModel
    {
        
        [BindProperty]
        public int? A { get; set; }
        
        [BindProperty]
        public int? B { get; set; }
        public void OnGet()
        {
            
        }
        public void OnPost(){
            if(ModelState.IsValid){
                NWD nwd = new NWD(A,B);
                
                nwd.NWDIter(A,B);
                ViewData["result"] = nwd.Result;
            }else{
                ViewData["result"] = "Brak wyniku";
            }
            
        }
       
    }
}
