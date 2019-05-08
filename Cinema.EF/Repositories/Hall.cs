using Cinema.EF.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.EF.Repositories
{
   public class HallRepozitory
    {
        public IEnumerable<Hall> GetAll()
        {
            using (var ctx = new CinemaEntities())
            {
                return ctx.Halls.ToList();
            }

        }

        public Hall GetOne(int Id)
        {
            using (var ctx = new CinemaEntities())
            {
                return ctx.Halls.Find(Id);
            }
        }

        public void AddHall(Hall Hall)
        {
            using (var ctx = new CinemaEntities())
            {
                ctx.Halls.Add(Hall);
            }
        }

        public void DeleteHall(int Id)
        {
            using (var ctx = new CinemaEntities())
            {
                Hall Hall = ctx.Halls.Find(Id);
                ctx.Halls.Remove(Hall);
            }
        }

    }
}