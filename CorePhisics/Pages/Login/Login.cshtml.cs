using CorePhisics.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;

namespace CorePhisics.Pages.Login
{
    public class LoginModel : PageModel
    {
        public string msg { get; set; }

          

        public void OnGet()
        {


        }
        public IActionResult OnPost(string userName, string password)
        {
            Helper helper = new Helper();
            string SQLString = $"SELECT * FROM [User] where '{userName}' = Username AND '{password}' = Password";
            string dt = "currentUser";
            try
            {
                DataTable currentUser = helper.RetrieveTable(SQLString, dt);
                if (currentUser.Rows.Count > 0)
                {
                    User user = new User();
                    user.Username = currentUser.Rows[0]["Username"].ToString();

                    user.FirstName = currentUser.Rows[0]["Username"].ToString();
                    user.LastName = currentUser.Rows[0]["LastName"].ToString();
                    user.Username = currentUser.Rows[0]["Username"].ToString();
                    user.Admin = (bool)(currentUser.Rows[0]["Admin"]);
                    string IsAdmin = (user.Admin == true) ? "Admin" : "NotAdmin";

                    HttpContext.Session.SetString("Admin", IsAdmin);
                    
                    HttpContext.Session.SetString("Username", user.Username);
                    HttpContext.Session.SetString("FirstName", user.FirstName);
                    HttpContext.Session.SetString("LastName", user.LastName);
                    
                    

                    //HttpContext.Session.SetString("Username", currentUser.Rows[0]["Username"].ToString());
                    //HttpContext.Session.SetString("FirstName", currentUser.Rows[0]["FirstName"].ToString());
                    //HttpContext.Session.SetString("LastName", currentUser.Rows[0]["LastName"].ToString());
                    //HttpContext.Session.SetString("Admin", currentUser.Rows[0]["Admin"].ToString());

                    return RedirectToPage("/Index");
                }
                else {
                     msg = "Wrong username or password";
                    return Page(); }

                //this.UserName = HttpContext.Session.GetString("FirstName").ToString();
                //this.Password = HttpContext.Session.GetString("LastName").ToString();
                //bool b = HttpContext.Session.GetString("FirstName").ToString().IsNullOrEmpty();

               
            }
            catch {
                return RedirectToPage("/Index");
            }


        }
    }
}
