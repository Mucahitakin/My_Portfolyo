using Microsoft.AspNetCore.Mvc;

namespace Mucahit_akin.Controllers
{
    public class ErrorController : Controller
    {   
        [Route("Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {

            switch (statusCode)
            {
                case 404:
                        ViewBag.ErrorMessage = "Üzgünüm sayfaya ulaşılamıyor.";
                    break;
            }

            return RedirectToAction("NotFound");
        }
        public IActionResult NotFound()
        {
            return View();
        }
    }
}
