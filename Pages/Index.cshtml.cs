using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualBasic;

namespace CorePhisics.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string Msg { get;  set;}

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;     
        }

        //public IActionResult OnGet()
        //{
        //    return Redirect("../html/index.html");
        //}

        public void OnGet()
        {

        }
        public void OnPost()
        {

    

        }
    }
}
