using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Data;
using Mucahit_akin.Model;

namespace Mucahit_akin.Controllers
{
    public class IletisimController : Controller
    {
        [HttpGet]
        public IActionResult Gorusme()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Gorusme(Gorusme grs)
        {
            if (ModelState.IsValid)
            {
                SqlConnection con = new SqlConnection("Data Source=MUCO;Integrated Security=True;Database=kendi_projem");
                SqlCommand cmd = new SqlCommand("Sp_iletisim", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@isim", SqlDbType.NVarChar).Value = grs.isim;
                cmd.Parameters.Add("@soyisim", SqlDbType.NVarChar).Value = grs.soyisim;
                cmd.Parameters.Add("@e_mail", SqlDbType.NVarChar).Value = grs.e_mail;
                
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)

                {
                    if ((int)dr["Sonuc"] == 0)
                    {
                        TempData["sonuc"] = "Girmiş olduğunuz mail adresi sisteme kayıtlıdır !";
                    }
                    else
                    {
                        TempData["sonuc"] = "Gönderim başarılı! Sizlere En kısa sürede mail atılacaktır.";

                    }

                }
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                TempData["sonuc"] = "Boş bir textbox bırakılamaz !";
            }

            return RedirectToAction("Gorusme");
        }

    }
}
