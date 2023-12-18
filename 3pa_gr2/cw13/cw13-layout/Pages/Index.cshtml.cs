using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{

    public class IndexModel : PageModel
    {
        [BindProperty]
        public List<string> Carols { get; set; }
        public IndexModel(){
            Carols = new List<string>{"asdasdsada ","wewqerr","wrwrwrwrwrw"};
        }
        public void OnGet()
        {
        }
    }
}
