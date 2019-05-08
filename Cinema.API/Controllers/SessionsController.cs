using Cinema.BuisnessLogic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Cinema.API.Controllers
{
    public class SessionsController : ApiController
    {
        private readonly ISessionServices _sessionServices;

        public SessionsController()
        {
            _sessionServices = new SessionServices();
        }

        [HttpGet]

        public IHttpActionResult GetAll()
        {
            var sessions = _sessionServices.GetAll();
            return Ok(sessions);
        }

        [HttpGet]

        public IHttpActionResult GetSessionById(int id)
        {
            var onesession = _sessionServices.GetOne(id);
            return Ok(onesession);
        }
    }
}
