using cw16_form.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class DeleteModel : PageModel
    {

        public IActionResult OnGet(string? id)
        {
            List<Person>? persons = FileRepo.GetAll();
            if(persons!=null) {
                var toDelete = persons.FirstOrDefault(p=>p.Id==id);
                if(toDelete!=null){
                    persons.Remove(toDelete);
                    FileRepo.SaveAll(persons);
                }
            }
            return RedirectToPage(nameof(Index));
        }
    }
}
