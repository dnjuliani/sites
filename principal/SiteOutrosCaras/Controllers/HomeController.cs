using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiteOutrosCaras.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.MetaGoogleSiteVerification = "";
            ViewBag.MetaDescription = "Banda carioca de Pop Rock formada por Danilo Juliani (Bateria), Felipe Juliani (Guitarra e Vocal) e Flavio Braga (Baixo e Vocal).";
            ViewBag.MetaAbstract = "Página oficial da banda Outros Caras, administrada pelos membros da banda e seu staff.";
            ViewBag.MetaAuthor = "Outros Caras";
            ViewBag.MetaCopyright = "Outros Caras";
            ViewBag.Title = "Banda Outros Caras";
            ViewBag.GoogleAnalyticsId = "UA-65298461-1";
            ViewBag.PageId = "home";
            return View();
        }
    }
}
