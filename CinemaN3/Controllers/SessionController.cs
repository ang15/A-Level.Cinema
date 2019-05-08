using Cinema.BuisnessLogic.Services;
using Cinema.EF.DataModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CinemaN3.Controllers
{
    public class SessionController : Controller
    {
        private readonly ISessionServices _sessionServices = new SessionServices();

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var sessions = _sessionServices.GetAll();
            return View(sessions);
        }
              

        [HttpPost]
        public ActionResult Add(Film_session session)
        {
            if (ModelState.IsValid)
            {
                _sessionServices.Add(session);
                return View();
            }
            return View(session);
                        
        }


        [HttpPost]
        public ActionResult DeleteSession(int id)
        {
            _sessionServices.Delete(id);
            return View();
        }

    }
}