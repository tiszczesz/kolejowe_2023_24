using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            var temp = Request;
            if(Request.Query!=null){

                //$a = $_GET['a']
                var firstname = Request.Query["firstname"];
                var lastname = Request.Query["lastname"];
            }
            
        }
        public void OnPost(){
            var temp = Request;
            if(Request.Form.Count>0){
                 var firstname = Request.Form["firstname"];
                var lastname = Request.Form["lastname"];
            }
        }
    }
}
