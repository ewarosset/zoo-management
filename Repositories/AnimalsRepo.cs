using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using Microsoft.Extensions.Logging;
using zoo_management.Controllers;
using zoo_management.Models.Database;
using zoo_management.Models.Requests;
using zoo_management.Models.Response;

namespace zoo_management.Repositories
{
    public interface IAnimalsRepo
    {
        public IEnumerable<Animal> ViewAll();
        public IEnumerable<Animal> Search(AnimalSearchRequest search);
        public int Count(AnimalSearchRequest search);
    }

    public class AnimalsRepo : IAnimalsRepo
    {
        private readonly ZooDbContext _context;

        public AnimalsRepo(ZooDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Animal> ViewAll()
        {
            return _context.Animals;
        }

        public IEnumerable<Animal> Search(AnimalSearchRequest search)
        {
            return _context.Animals
                .Where(animal => search.Search == null ||
                                 (animal.Species.ToLower().Contains(search.Search)) ||
                                 (animal.Classification.ToLower().Contains(search.Search)) ||
                                 (animal.Name.ToLower().Contains(search.Search)) ||
                                 SqlFunctions.StringConvert((double) animal.Age).Contains(search.Search)
                    // (animal.Age.Equals(Int32.Parse(search.Search)))
                    // (animal.DateAcquired.ToString("dd-MM-YYYY").Contains(search.Search))
                )
                .OrderBy(animal => animal.Species)
                .Skip((search.Page - 1) * search.PageSize)
                .Take(search.PageSize);
        }

        public int Count(AnimalSearchRequest search)
        {
            return _context.Animals
                .Count(a => search.Search == null ||
                            (
                                a.Species.ToLower().Contains(search.Search) ||
                                a.Classification.ToLower().Contains(search.Search) ||
                                a.Name.ToLower().Contains(search.Search) ||
                                SqlFunctions.StringConvert((double) a.Age).Contains(search.Search)
                                // a.Age.Equals(Int32.Parse(search.Search))
                                // a.DateAcquired.ToString("dd-MM-YYYY").Contains(search.Search)
                            ));
        }
    }
}