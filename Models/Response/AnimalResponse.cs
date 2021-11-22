using System;
using zoo_management.Models.Database;

namespace zoo_management.Models.Response
{
    public class AnimalResponse
    {
        private readonly Animal _animal;

        public AnimalResponse(Animal animal)
        {
            _animal = animal;
        }

        public int Id => _animal.Id;

        public string Species => _animal.Species;

        public string Classification => _animal.Classification;

        public string Name => _animal.Name;

        public int Age => _animal.Age;

        public DateTime DateAcquired => _animal.DateAcquired;
    }
}