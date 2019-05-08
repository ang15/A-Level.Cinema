using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.BuisnessLogic.Dto
{
    public class FilmDto
    {
        public string Name { get; set; }

        public string ScreenShoots  { get; set; }
        
        public double Duration { get; set; }

        public List<GenreDto> GenreList { get; set; }

        public List<CountryDto> CountryList { get; set; }

        public List<HallDto> HallList { get; set; }

        
    }
}
