using Cinema.BuisnessLogic.Dto;
using Cinema.EF.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.BuisnessLogic.Extensions
{
    public static class HallExtension
    {
        public static HallDto ToHallDto(this Hall hall)
        {
            if (hall == null)
                return null;

            var hallDto = new HallDto
            {
                Name = hall.Name,               

            };

            return hallDto;
        }
    }
}
