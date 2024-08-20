using CorePhisics.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using System.Data;


namespace CorePhisics.Pages.Admin
{
    public class AdminModel : PageModel
    {
        public string TableDiv { get; set; }

        //public void OnGet()
        //{
        //}

        public void OnPost()
        {
            Helper helper = new Helper();
            string SQLString = "SELECT * FROM [User]";
            string dt = "currentUser";
            try
            {
                DataTable userTable = helper.RetrieveTable(SQLString, dt);
                TableDiv = helper.BuildUsersTable(userTable);
            }
            catch
            {

            }






        }
    }
}
