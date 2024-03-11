using CurlingChalleng.Classes;
using CurlingChalleng.PageModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Syncfusion.EJ2.Diagrams;

namespace CurlingChalleng.Pages
{
    
    public class IndexModel : PageModel
    {
        [BindProperty]
        public DiskModel disk{ get; set; }
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public ActionResult OnGet()
        {

            //Nodes();
            return Page();
            
        }
        public ActionResult OnPost() {
            var diskShape = Request.Form["diskShape"];
            var diskNumber = Request.Form["diskNumber"];
            var diskDim = Request.Form["diskDim"];

            disk = new DiskModel();
            disk.Shape = diskShape;
            disk.Number = Int32.Parse(diskNumber);
            disk.Dim = Int32.Parse(diskDim);
        
            return RedirectToPage("Result", disk);
        }


    }
}