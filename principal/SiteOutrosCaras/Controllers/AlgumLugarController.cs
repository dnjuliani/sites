using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiteOutrosCaras.Controllers
{
    public class AlgumLugarController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.MetaGoogleSiteVerification = "";
            ViewBag.MetaDescription = "O CD Algum lugar foi gravado em 2013, no estúdio Valda Friends, no Rio de Janeiro, e conta com 10 músicas inéditas";
            ViewBag.MetaAbstract = "O primeiro CD Algum Lugar é o primeiro completo dos Outros Caras";
            ViewBag.MetaAuthor = "Outros Caras";
            ViewBag.MetaCopyright = "Outros Caras";
            ViewBag.Title = "Algum Lugar - Banda Outros Caras";
            ViewBag.GoogleAnalyticsId = "UA-65298461-1";
            ViewBag.PageId = "home";
            return View();
        }
    }
}