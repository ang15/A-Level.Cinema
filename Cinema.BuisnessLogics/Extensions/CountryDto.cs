using Cinema.BuisnessLogic.Dto;
using Cinema.EF.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.BuisnessLogic.Extensions
{
    public static class CountryExtension
    {
        public static CountryDto ToCountryDto(this Country country)
        {
            if (country == null)
                return null;

            var countryDto = new CountryDto
            {
                Name = country.Name,

            };

            return countryDto;
        }
    }
}
