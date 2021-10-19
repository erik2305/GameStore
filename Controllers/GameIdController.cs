using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GameStore.Models;

namespace GameStore.Controllers
{
    public class GameIdController : Controller
    {
        private CVGSEntities db = new CVGSEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FinalFantasy4()
        {
            return View();
        }

        public ActionResult NHL09()
        {
            return View();
        }

        public ActionResult Fallout3(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Game game = db.Games.Find(id);
            if (game == null)
            {
                return HttpNotFound();
            }
            return View(game);
        }

        public ActionResult TombRaiderUW()
        {
            return View();
        }

        public ActionResult CoDWaW()
        {
            return View();
        }

        public ActionResult RainbowSixV2()
        {
            return View();
        }
    }
}