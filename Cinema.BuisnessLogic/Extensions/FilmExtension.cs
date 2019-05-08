using Cinema.BuisnessLogic.Dto;
using Cinema.EF.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.BuisnessLogic.Extensions
{
    public static class FilmExtension
    {
        public static FilmDto ToFilmDto(this Film film)
        {
            if (film == null)
                return null;

            var filmDto = new FilmDto
            {
                Name = film.Name,
                ScreenShoots = film.ScrennShoots,
                GenreList = film.Genres.Select(x => x.ToGenreDto()).ToList(),
                CountryList = film.Countries.Select(x => x.ToCountryDto()).ToList(),     

            };

            return filmDto;
        }
    }
}
