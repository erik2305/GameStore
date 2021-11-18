using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using GameStore.Models;

namespace GameStore.Controllers
{
    public class GamesController : Controller
    {
        private CVGS_Tables db = new CVGS_Tables();
        /*
        private System.Text.RegularExpressions.Regex NotYoutubeRegex =
            new System.Text.RegularExpressions.Regex (Validators.MyRegex.NotYoutubeRegex);
        private string youtubeViewLink = "https://www.youtube.com/watch?v=";
        */
        public GamesController() { }

        // GET: Games
        public ActionResult Index()
        {
            var games = db.Games.Include(g => g.EsrbRating)
                                .Include(g => g.GameCategory)
                                .Include(g => g.GamePerspective)
                                .Include(g => g.GameStatu)
                                .Include(g => g.GameSubCategory);
            return View(games.ToList());
        }

        // GET: Games/Details/5
        public ActionResult Details(Guid? id)
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
            if (game.FrenchVersion && game.FrenchTrailer != null)
            {
                game.FrenchTrailer = Regex.Replace(game.FrenchTrailer, Validators.MyRegex.NotYoutubeRegex, "");
            }
            game.EnglishTrailer = Regex.Replace(game.EnglishTrailer, Validators.MyRegex.NotYoutubeRegex, "");
            return View(game);
        }

        // GET: Games/Create
        public ActionResult Create()
        {
            ViewBag.EsrbRatingCode = new SelectList(db.EsrbRatings, "Code", "EnglishRating");
            ViewBag.GameCategoryId = new SelectList(db.GameCategories, "Id", "EnglishCategory");
            ViewBag.GamePerspectiveCode = new SelectList(db.GamePerspectives, "Code", "EnglishPerspectiveName");
            ViewBag.GameStatusCode = new SelectList(db.GameStatus, "Code", "EnglishCategory");
            ViewBag.GameSubCategoryId = new SelectList(db.GameSubCategories, "Id", "EnglishCategory");
            return View();
        }

        // POST: Games/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Guid,GameStatusCode,GameCategoryId,GameSubCategoryId,EsrbRatingCode," +
            "EnglishName,FrenchName,FrenchVersion,EnglishPlayerCount,FrenchPlayerCount,GamePerspectiveCode," +
            "EnglishTrailer,FrenchTrailer,EnglishDescription,FrenchDescription,EnglishDetail,FrenchDetail,UserName")] Game game)
        {
            if (ModelState.IsValid)
            {

                if (!game.FrenchVersion)
                {
                    game.FrenchName = "";
                    game.FrenchPlayerCount = "0";
                    game.FrenchTrailer = "";
                    game.FrenchDescription = "";
                    game.FrenchDetail = "";
                }
                game.Guid = Guid.NewGuid();
                db.Games.Add(game);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EsrbRatingCode = new SelectList(db.EsrbRatings, "Code", "EnglishRating", game.EsrbRatingCode);
            ViewBag.GameCategoryId = new SelectList(db.GameCategories, "Id", "EnglishCategory", game.GameCategoryId);
            ViewBag.GamePerspectiveCode = new SelectList(db.GamePerspectives, "Code", "EnglishPerspectiveName", game.GamePerspectiveCode);
            ViewBag.GameStatusCode = new SelectList(db.GameStatus, "Code", "EnglishCategory", game.GameStatusCode);
            ViewBag.GameSubCategoryId = new SelectList(db.GameSubCategories, "Id", "EnglishCategory", game.GameSubCategoryId);
            return View(game);
        }

        // GET: Games/Edit/5
        public ActionResult Edit(Guid? id)
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
            if (game.FrenchVersion && game.FrenchTrailer != null)
            {
                game.FrenchTrailer = Regex.Replace(game.FrenchTrailer, Validators.MyRegex.NotYoutubeRegex, "https://www.youtube.com/watch?v=");
            }
            game.EnglishTrailer = Regex.Replace(game.EnglishTrailer, Validators.MyRegex.NotYoutubeRegex, "https://www.youtube.com/watch?v=");
            ViewBag.EsrbRatingCode = new SelectList(db.EsrbRatings, "Code", "EnglishRating", game.EsrbRatingCode);
            ViewBag.GameCategoryId = new SelectList(db.GameCategories, "Id", "EnglishCategory", game.GameCategoryId);
            ViewBag.GamePerspectiveCode = new SelectList(db.GamePerspectives, "Code", "EnglishPerspectiveName", game.GamePerspectiveCode);
            ViewBag.GameStatusCode = new SelectList(db.GameStatus, "Code", "EnglishCategory", game.GameStatusCode);
            ViewBag.GameSubCategoryId = new SelectList(db.GameSubCategories, "Id", "EnglishCategory", game.GameSubCategoryId);
            return View(game);
        }

        // POST: Games/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Guid,GameStatusCode,GameCategoryId,GameSubCategoryId,EsrbRatingCode,EnglishName,FrenchName,FrenchVersion,EnglishPlayerCount,FrenchPlayerCount,GamePerspectiveCode,EnglishTrailer,FrenchTrailer,EnglishDescription,FrenchDescription,EnglishDetail,FrenchDetail,UserName")] Game game)
        {
            if (ModelState.IsValid)
            {
                if (!game.FrenchVersion)
                {
                    game.FrenchName = "";
                    game.FrenchPlayerCount = "0";
                    game.FrenchTrailer = "";
                    game.FrenchDescription = "";
                    game.FrenchDetail = "";
                }
                db.Entry(game).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EsrbRatingCode = new SelectList(db.EsrbRatings, "Code", "EnglishRating", game.EsrbRatingCode);
            ViewBag.GameCategoryId = new SelectList(db.GameCategories, "Id", "EnglishCategory", game.GameCategoryId);
            ViewBag.GamePerspectiveCode = new SelectList(db.GamePerspectives, "Code", "EnglishPerspectiveName", game.GamePerspectiveCode);
            ViewBag.GameStatusCode = new SelectList(db.GameStatus, "Code", "EnglishCategory", game.GameStatusCode);
            ViewBag.GameSubCategoryId = new SelectList(db.GameSubCategories, "Id", "EnglishCategory", game.GameSubCategoryId);
            return View(game);
        }

        // GET: Games/Delete/5
        public ActionResult Delete(Guid? id)
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

        // POST: Games/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Game game = db.Games.Find(id);
            db.Games.Remove(game);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
