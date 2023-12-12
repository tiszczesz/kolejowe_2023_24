using cw12_empty;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
   
    public class HollidayModel : PageModel
    {
        [BindProperty]
        public List<Gift> Gifts { get; set; }
        public HollidayModel()
        {
            Gifts = GiftRepo.GetGifts();
        }
        public void OnGet()
        {
        }
    }
}
