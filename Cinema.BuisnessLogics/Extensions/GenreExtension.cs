using Cinema.BuisnessLogic.Dto;
using Cinema.EF.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.BuisnessLogic.Extensions
{
    public static class GenreExtension
    {
        public static GenreDto ToGenreDto(this Genre genre)
        {
            if (genre == null)
                return null;

            var genreDto = new GenreDto
            {
                Name = genre.Name,

            };

            return genreDto;
        }
    }
}
