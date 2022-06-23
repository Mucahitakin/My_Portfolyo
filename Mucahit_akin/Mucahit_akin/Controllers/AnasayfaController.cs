using Mucahit_akin.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;


namespace Mucahit_akin.Controllers
{
    public class AnasayfaController : Controller
    {
        
        public IActionResult baslangic()
        {
            SqlConnection con = new SqlConnection("Data Source = MUCO; Integrated Security = True; Database=kendi_projem");
            SqlCommand cmd = new SqlCommand("Sp_projeListe", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt =new DataTable();
            adapter.Fill(dt);
            List<Anasayfa>lst = new List<Anasayfa>();
            foreach (DataRow dr in dt.Rows)
            {
                lst.Add(new Anasayfa() { id = Convert.ToInt32(dr["id"]), project_name = dr["project_name"].ToString(), explanation = dr["explanation"].ToString(), url = dr["url"].ToString() });
            }



            return View(lst);
        }
    }
}
