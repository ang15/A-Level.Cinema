using Cinema.BuisnessLogic.Servies;
using Cinema.EF.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Cinema.API.Controllers
{
    public class FilmsController : ApiController
    {
        public IFilmServices _filmServices;

        public FilmsController()
        {
            _filmServices = new FilmServices();
        }

        [HttpGet]

        public IHttpActionResult GetAll()
        {
            var films = _filmServices.GetAll();  //where GetAll Create in Film services
            return Ok(films);
        }

        

        [HttpPost]


        public IHttpActionResult Add([FromBody] Film film)  //Film from  EF
        {
            _filmServices.Add(film);
            return Ok();
        }


        [HttpDelete]

        public IHttpActionResult Delete(int id)
        {
            if (!ModelState.IsValid)
                return (BadRequest(ModelState));

            _filmServices.Delete(id);

            return Ok();
        }

        [HttpGet]

        public IHttpActionResult GetOne(int id)
        {
            var onefilm = _filmServices.GetOne(id); //  Look like GetList().FirstOrDefault(x => x.Id == id)
            return Ok(onefilm);
        }

    }
}
