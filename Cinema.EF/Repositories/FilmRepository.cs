using Cinema.EF.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.EF.Repositories
{
    public class FilmRepository
    {
        //public List<Film> FilmList = new List<Film>();

        //public List<Film> filmEF;
        public List<Film> GetAll()
        {
            //var context = new CinemaEntities();


            //filmEF = context.Films.ToList();

            ////foreach (var f in filmEF)
            ////{
            ////    FilmList.Add(f);
            ////}
            //return Film;


            var ctx = new CinemaEntities();

            var list = ctx.Films.ToList();

            return list;
            
            
        }

        public Film GetOne(int Id)
        {
            using (var ctx = new CinemaEntities())
            {
                return ctx.Films.Find(Id);
            }
        }

        public void AddFilm(Film film)
        {
            using (var ctx = new CinemaEntities())
            {
                ctx.Films.Add(film);
            }
        }

        public void DeleteFilm(int Id)
        {
            using (var ctx = new CinemaEntities())
            {
                Film film = ctx.Films.Find(Id);
                ctx.Films.Remove(film);
            }
        }
    }
}