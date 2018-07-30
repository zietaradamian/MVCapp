using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCapp.Controllers
{
    public class HelperController : Controller
    {
        // GET: Helper
        public ActionResult Index()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;"
                +"AttachDbFilename=C:\\Users\\Damian\\source\\repos\\MVCapp\\MVCapp\\App_Data\\BAZAADONET.mdf;Integrated Security=True";

            string query = "Select Nazwa, Email From dbo.KontaktyADO where id= @id";

            int id = 2;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                reader.Read();

                var nazwa = reader[0];
                var email = reader[1];
               
                ViewBag.Nazwa = nazwa;
                ViewBag.Email = email;
            }
                return View();
        }
    }
}