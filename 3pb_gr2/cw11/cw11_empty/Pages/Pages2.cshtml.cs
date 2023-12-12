using cw11_empty;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class Pages2Model : PageModel
    {
        [BindProperty]
        public List<Person> Persons { get; set; }
        public Pages2Model()
        {
            Persons = PersonRepo.GetPersons();
        }
        public void OnGet()
        {
        }
    }
}
