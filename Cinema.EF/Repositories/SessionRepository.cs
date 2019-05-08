using Cinema.EF.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.EF.Repositories
{
    public class SessionRepository
    {

        public List<Film_session> GetAll()
        {
            using (var ctx = new CinemaEntities())
            {
                return ctx.Film_sessions.ToList();
            }

        }

        public void AddSession(Film_session film_session)
        {
            using (var ctx = new CinemaEntities())
            {
                ctx.Film_sessions.Add(film_session);
            }
        }

        public void DeleteSession(int Id)
        {
            using (var ctx = new CinemaEntities())
            {
                Film_session session = ctx.Film_sessions.Find(Id);
                ctx.Film_sessions.Remove(session);
            }
        }

        public Film_session GetOne(int Id)
        {
            using (var ctx = new CinemaEntities())
            {
                return ctx.Film_sessions.Find(Id);
            }
        }
    }
}
