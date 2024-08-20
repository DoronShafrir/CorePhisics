using CorePhisics.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;

namespace CorePhisics.Pages.Login
{
    public class LogUpModel : PageModel
    {
        public string msg { get; set; }



        public void OnGet()
        {


        }
        public IActionResult OnPost(string fName, string lname, string userName, string password, string email, int tel, DateOnly dName)
        {
            Helper helper = new Helper();

            string table = "[User]";

            User user = new User()
            {
                FirstName = fName,
                LastName = lname,
                Username = userName,
                Password = password,
                Email = email,
                Phone = tel,
                Birthday = dName
            };

            int n = helper.Insert(user, table);
            if (n > 0) return RedirectToPage("/Index");
            else
            {
                msg = "USER NAME is already in use";
                return Page();
            }
        }

    }
}

