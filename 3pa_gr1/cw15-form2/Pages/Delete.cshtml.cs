using cw15_form2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class DeleteModel : PageModel
    {
        private FileRepo _repo;
        public DeleteModel()
        {
            _repo = new FileRepo();
        }
        public IActionResult OnGet(string? name)
        {
            var welcomes = _repo.GetAll();
            var toDelete = welcomes.FirstOrDefault(w=>w.Name==name);
            if(toDelete!=null){
                welcomes.Remove(toDelete);
                _repo.SaveAll(welcomes); //todo
            }
            return RedirectToPage(nameof(Index));
        }
    }
}
