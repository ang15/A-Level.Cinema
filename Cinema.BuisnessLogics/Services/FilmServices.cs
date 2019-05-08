using Cinema.BuisnessLogic.Dto;
using Cinema.BuisnessLogic.Extensions;
using Cinema.EF.DataModel;
using Cinema.EF.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.BuisnessLogic.Servies
{
    public interface IFilmServices
    {
        FilmDto GetOne(int id);

        void Delete(int id);

        void Add(Film film);

        List<FilmDto> GetAll();
    }

    public class FilmServices : IFilmServices
    {
        private readonly FilmRepository _filmRepository;

        public FilmServices()
        {
            _filmRepository = new FilmRepository();
        }

        public List<FilmDto> GetAll()
        {

            var repository = new FilmRepository();

            var filmList = repository.GetAll();

            return filmList.Select(x => x.ToFilmDto()).ToList();

            //return _filmRepository.GetAll()
            //    .OrderBy(g => g.Name)
            //    .ToList();

        }

        public FilmDto GetOne(int id)
        {
            var films = _filmRepository.GetOne(id);

            return films.ToFilmDto();            
        }

        public void Add(Film film)
        {
            _filmRepository.AddFilm(film);
        }

        public void Delete(int id)
        {
            _filmRepository.DeleteFilm(id);
        }

        //public void Update(Film film)
        //{
        //    _filmRepository.Update(film);
        //}

    }
}
