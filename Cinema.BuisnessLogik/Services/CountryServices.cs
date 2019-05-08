using Cinema.EF.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.BuisnessLogic.Services
{
    public interface ICountryServices
    {
        Country GetOne(int id);

        void Delete(int id);

        void Add(Country country);

        void Update(Country country);

        List<Country> GetAll();
    }

    //public class CountryServices : ICountryServices
    //{
    //    private readonly CountryRepository _countryRepository;

    //    public CountryServices()
    //    {
    //        _countryRepository = new CountryRepository();
    //    }

    //    public List<Country> GetAll()
    //    {
    //        return _countryRepository.GetAll()
    //            .OrderBy(g => g.Name)
    //            .ToList();

    //    }

    //    public Country GetOne(int id)
    //    {
    //        return _countryRepository.GetOne(id);
    //    }

    //    public void Add(Country country)
    //    {
    //        _countryRepository.Add(country);
    //    }

    //    public void Delete(int id)
    //    {
    //        _countryRepository.Delete(id);
    //    }

    //    public void Update(Country country)
    //    {
    //        _countryRepository.Update(country);
    //    }
    //}
}
