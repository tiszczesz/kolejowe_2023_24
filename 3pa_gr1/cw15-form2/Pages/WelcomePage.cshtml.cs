using cw15_form2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cw15_form2.Pages
{
	public class WelcomePageModel : PageModel
	{
        [BindProperty]
        public Welcome	MyWelcome { get; set; }
        public void OnGet()
		{
		}
		public IActionResult OnPost()
		{
			if(ModelState.IsValid)
			{
			//	var result = MyWelcome;
				FileRepo.AddToFile(MyWelcome);
				return RedirectToPage("./Index");
			}
			return Page();
		}
	}
}
