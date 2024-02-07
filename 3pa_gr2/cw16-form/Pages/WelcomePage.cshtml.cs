using cw16_form.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cw16_form.Pages
{
    public class WelcomePageModel : PageModel
    {
        [BindProperty]
        public Person  MyPerson { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost() {
            if (ModelState.IsValid)
            {
                FileRepo.AddToFile(MyPerson);
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
