using cw16_form2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cw16_form2.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public List<Person> Persons { get; set; }
         

        public void OnGet()
        {
           Persons = FileRepo.GetAll();
        }
    }
}
