using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using BidAndAuction.Models;

namespace BidAndAuction.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Login lcm)
        {

            string str = "Data Source=ABTR14F1D;Initial Catalog=GreenHopper;Integrated Security=False;User ID=sa;Password=P@ssw0rd1;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";

            using (SqlConnection conn = new SqlConnection(str))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = " select * FROM EmpDets  where EmpEmailID='" + lcm.EmpEmailID + "' and EmplID='" + lcm.EmplID + "'";
                    cmd.CommandType = System.Data.CommandType.Text;
                    SqlDataReader sdr = cmd.ExecuteReader();

                    return RedirectToAction("ProductDetails", "ProductDetails");


                }
                catch (Exception e)
                {
                    throw e;
                }
              
            }

            return View();
        }


	}
}