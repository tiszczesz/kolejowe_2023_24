using cw16_form.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cw16_form.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        
        [BindProperty]
        public List<Person>? Persons { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;            
        }

        public void OnGet()
        {
            Persons = FileRepo.GetAll();
        }
    }
}
