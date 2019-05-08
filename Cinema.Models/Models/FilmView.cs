using Cinema.BuisnessLogic.Dto;
using Cinema.EF.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Models.Models
{
    public class FilmView:FilmDto
    {
        //public int Id { get; set; }
        //public string ScrennShoots { get; set; }
        //public float Duration { get; set; }

        public FilmView() { }

        public FilmView(FilmDto filmDto)
        {
            Name = filmDto.Name;            
            GenreList = filmDto.GenreList;
            CountryList = filmDto.CountryList;
        }
    }
}
