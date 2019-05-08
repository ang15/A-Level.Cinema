using Cinema.BuisnessLogic.Servies;
using Cinema.EF.DataModel;
using Cinema.Models.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CinemaN3.Controllers
{
    public class FilmController : Controller
    {
        private readonly IFilmServices _filmServices = new FilmServices();

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var films = _filmServices.GetAll();
            var filmViewModel = films.Select(x => new FilmView(x));
            return View(filmViewModel);
        }

        [HttpGet]
        public ActionResult GetOne(int id)
        {
            var filmOne = _filmServices.GetOne(id);
            var path = Path.Combine("/img" + filmOne.ScreenShoots + ".jpg");
            return View(filmOne.Name, path, filmOne.Duration);
        }

        [HttpGet]
        public ActionResult GetOneImg(int id)
        {
            var filmOne = _filmServices.GetOne(id);
            var path = Path.Combine("/img" + filmOne.ScreenShoots + ".jpg");
            return View(filmOne.Name, filmOne.Duration);
        }

        [HttpPost]
        public ActionResult Add(Film film)
        {
            if (ModelState.IsValid)
            {
                _filmServices.Add(film);
                return View();
            }
            return View(film);
                        
        }


        [HttpPost]
        public ActionResult DeleteFilm(int id)
        {
            _filmServices.Delete(id);
            return View();
        }

    }
}