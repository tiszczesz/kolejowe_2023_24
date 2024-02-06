using cw15_forms.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cw15_forms.Pages
{
    public class TodoPageModel : PageModel
    {
        [BindProperty]
        public Todo  MyTodo{ get; set; }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                FileRepo.SaveToFile(MyTodo);
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
