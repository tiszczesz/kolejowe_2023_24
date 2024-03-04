using cw15_form2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cw15_form2.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;

		[BindProperty]
		public List<Welcome>? Welcomes { get; set; }
		private FileRepo _repo;
		public IndexModel(ILogger<IndexModel> logger)
		{
			_logger = logger;
			_repo = new FileRepo();
		}

		public void OnGet()
		{
			Welcomes = _repo.GetAll().OrderBy(w=>w.DateGo).ToList();
		}
	}
}
