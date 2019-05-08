using Cinema.BuisnessLogic.Dto;
using Cinema.EF.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.BuisnessLogic.Extensions
{
    public static class SessionExtension
    {
        public static SessionDto ToSessionDto(this Film_session film_session)
        {
            if (film_session == null)
                return null;

            var film_sessionDto = new SessionDto
            {
                Slot = film_session.Slot.Value,
                
            };

            return film_sessionDto;
        }
    }
}

