using cw15.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cw15.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    
    [BindProperty]
    public int Result { get; set; }=0;
    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
    public void OnPost(){
        try{
            int a = Convert.ToInt32(Request.Form["a"]);
            int b = Convert.ToInt32(Request.Form["b"]);
            
            Result = NWD.NWDRec(a,b);
        }catch(FormatException ex){
            ViewData["error"] = $"Błąd: {ex.Message}";
        }
        
    }
}
