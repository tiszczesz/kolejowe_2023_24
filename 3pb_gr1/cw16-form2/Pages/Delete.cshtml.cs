using cw16_form2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class DeleteModel : PageModel
    {
        public IActionResult OnGet(string? id)
        {
            var persons = FileRepo.GetAll();
            var persontoDelete = persons.FirstOrDefault(p=>p.Id==id);
            if(persontoDelete!=null){
                persons.Remove(persontoDelete);
                FileRepo.SaveAll(persons);
            }
            return RedirectToPage(nameof(Index));
        }
    }
}
