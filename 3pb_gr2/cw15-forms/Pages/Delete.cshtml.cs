using cw15_forms.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class DeleteModel : PageModel
    {
        public IActionResult OnGet(string? id)
        {
            var todos = FileRepo.GetAll();
            var toDelete = todos.FirstOrDefault(t=>t.Id==id);
            if(toDelete!=null) {
                todos.Remove(toDelete);
                FileRepo.SaveAll(todos);                
            }
            return RedirectToPage(nameof(Index));
        }
    }
}
