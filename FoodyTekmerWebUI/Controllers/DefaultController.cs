using Microsoft.AspNetCore.Mvc;

namespace FoodyTekmerWebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {

            ViewBag.Title1 = "Ürünler";
            ViewBag.Title2 = "Ana Sayfa";
            ViewBag.Title3 = "Sayfalar";
            ViewBag.Title4 = "Ürün Listesi";


            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialPageHeader()
        {
           
            return PartialView(ViewBag); 


        }
    }
}
