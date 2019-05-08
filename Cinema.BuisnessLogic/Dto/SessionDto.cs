using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.BuisnessLogic.Dto
{
    public class SessionDto
    {
        
        public DateTime Slot { get; set; }

        public List<FilmDto> FilmList { get; set; }

        public List<HallDto> HallList { get; set; }
    }
}
