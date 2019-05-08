using Cinema.BuisnessLogic.Dto;
using Cinema.BuisnessLogic.Extensions;
using Cinema.EF.DataModel;
using Cinema.EF.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.BuisnessLogic.Services
{
    public interface ISessionServices
    {
        SessionDto GetOne(int id);

        void Delete(int id);

        void Add(Film_session session);

        //void Update(Film_session session);

        List<SessionDto> GetAll();
    }

    public class SessionServices : ISessionServices
    {
        private readonly SessionRepository _sessionRepository;

        public SessionServices()
        {
            _sessionRepository = new SessionRepository();
        }

        public List<SessionDto> GetAll()
        {

            var repository = new SessionRepository();

            var sessionList = repository.GetAll();

            return sessionList.Select(x => x.ToSessionDto()).ToList();

            //return _sessionRepository.GetAll()    
            //    .OrderBy(g => g.Slot)
            //    .ToList();

        }

        public SessionDto GetOne(int id)
        {
            var sessions = _sessionRepository.GetOne(id);

            return sessions.ToSessionDto();
            
        }

        public void Add(Film_session session)
        {
            _sessionRepository.AddSession(session);
        }

        public void Delete(int id)
        {
            _sessionRepository.DeleteSession(id);
        }

        //public void Update(Film_session session)
        //{
        //    _sessionRepository.Update(session);
        //}

    }
}
