using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationLab5True.Models;

namespace WebApplicationLab5True.Controllers
{
    public class WineryController : Controller
    {
        private static List<WineryModel> Wines = new List<WineryModel>()
    {
        new WineryModel { ID = 1, WineName = "GoodWine", Grape = "merlo", Acl = 12, HarvestDate = new DateTime(2011, 11, 24), Price = 1500 }
    };

        private void AddWine(WineryModel Wine)
        {
            Wine.ID = Wines.Count + 1;
            Wines.Add(Wine);
        }

        public ActionResult Index()
        {
            return View(Wines.ToList());
        }

        [HttpGet]
        public ActionResult CreateWine()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateWine(WineryModel Wine)
        {
            if (ModelState.IsValid)
            {
                AddWine(Wine);
                return RedirectToAction("Index");
            }
            return View(Wine);
        }

    }
}
