using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class DeleteModel : PageModel
    {
        public IActionResult OnGet(string? id)
        {
            return RedirectToPage(nameof(Index));
        }
    }
}
