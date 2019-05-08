using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Models.Models
{
    public class Session
    {
        public int Id { get; set; }
        public List<FilmView> Film { get; set; }
        public DateTime Sloat { get; set; }
        public List<Hall> Hall { get; set; }
    }
}
