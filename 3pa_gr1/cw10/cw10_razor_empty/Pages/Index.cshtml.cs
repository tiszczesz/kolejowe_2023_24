using cw10_razor_empty;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public List<Student> MyStudents { get; set; }
        public IndexModel()
        {
            MyStudents = Students.GetAll();
        }
        public void OnGet()
        {
        }
    }
}
