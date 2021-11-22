using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;
using zoo_management.Models.Database;

namespace zoo_management.Data
{
    public static class SampleAnimals
    {
        public const int NumberOfAnimals = 100;

        private static readonly IList<IList<string>> Data = new List<IList<string>>
        {
            new List<string> {"Amur Leopard", "bird", "Emily", "M", "15/04/1995", "15/04/1995",},
            new List<string> {"Black Rhino", "insect", "Sophia", "M", "16/04/1995", "16/04/1995",},
            new List<string> {"Bornean Orangutan", "fish", "Grace", "F", "02/05/2019", "02/05/2019",},
            new List<string> {"Cross River Gorilla", "invertebrate", "Mia", "F", "03/05/2019", "03/05/2019",},
            new List<string> {"Eastern Lowland Gorilla", "fish", "Poppy", "M", "04/05/2019", "04/05/2019",},
            new List<string> {"Hawksbill Turtle", "invertebrate", "Ella", "M", "05/05/2019", "05/05/2019",},
            new List<string> {"Javan Rhino", "mammal", "George", "M", "06/05/2019", "06/05/2019",},
            new List<string> {"Orangutan", "reptile", "Harry", "F", "07/05/2019", "07/05/2019",},
            new List<string> {"Saola", "bird", "Noah", "F", "08/05/2019", "08/05/2019",},
            new List<string> {"Sumatran Elephant", "insect", "Jack", "F", "09/05/2019", "09/05/2019",},
            new List<string> {"Sumatran Orangutan", "fish", "Charlie", "M", "10/05/2019", "10/05/2019",},
            new List<string> {"Sumatran Rhino", "invertebrate", "Leo", "F", "11/05/2019", "11/05/2019",},
            new List<string> {"Sunda Tiger", "mammal", "Jacob", "M", "03/05/2018", "03/05/2018",},
            new List<string> {"Vaquita", "reptile", "Freddie", "M", "04/05/2018", "04/05/2018",},
            new List<string> {"Western Lowland Gorilla", "bird", "Alfie", "F", "05/05/2018", "05/05/2018",},
            new List<string> {"Yangtze Finless Porpoise", "insect", "Isla", "F", "06/05/2018", "06/05/2018",},
            new List<string> {"African savanna elephant", "fish", "Ava", "M", "07/05/2018", "07/05/2018",},
            new List<string> {"African Wild Dog", "invertebrate", "Emily", "M", "08/05/2018", "08/05/2018",},
            new List<string> {"Asian Elephant", "fish", "Sophia", "M", "09/05/2018", "09/05/2018",},
            new List<string> {"Black-footed Ferret", "invertebrate", "Grace", "F", "10/05/2018", "10/05/2018",},
            new List<string> {"Blue Whale", "mammal", "Mia", "F", "11/05/2018", "11/05/2018",},
            new List<string> {"Bluefin Tuna", "reptile", "Poppy", "F", "12/05/2018", "12/05/2018",},
            new List<string> {"Bonobo", "bird", "Ella", "M", "13/05/2018", "13/05/2018",},
            new List<string> {"Bornean Elephant", "insect", "George", "F", "14/05/2018", "14/05/2018",},
            new List<string> {"Chimpanzee", "fish", "Harry", "M", "15/05/2018", "15/05/2018",},
            new List<string> {"Fin Whale", "invertebrate", "Noah", "M", "16/05/2018", "16/05/2018",},
            new List<string> {"Galápagos Penguin", "mammal", "Jack", "F", "27/07/2015", "27/07/2015",},
            new List<string> {"Ganges River Dolphin", "reptile", "Charlie", "F", "28/07/2015", "28/07/2015",},
            new List<string> {"Green Turtle", "bird", "Leo", "M", "29/07/2015", "29/07/2015",},
            new List<string> {"Hector's Dolphin", "insect", "Jacob", "M", "30/07/2015", "30/07/2015",},
            new List<string> {"Humphead Wrasse", "fish", "Freddie", "M", "31/07/2015", "31/07/2015",},
            new List<string> {"Indian Elephant", "invertebrate", "Alfie", "F", "01/08/2015", "01/08/2015",},
            new List<string> {"Indus River Dolphin", "fish", "Isla", "F", "02/08/2015", "02/08/2015",},
            new List<string> {"Irrawaddy Dolphin", "invertebrate", "Ava", "F", "03/08/2015", "03/08/2015",},
            new List<string> {"Mountain Gorilla", "mammal", "Emily", "M", "04/08/2015", "04/08/2015",},
            new List<string> {"North Atlantic Right Whale", "reptile", "Sophia", "F", "05/08/2015", "05/08/2015",},
            new List<string> {"Red Panda", "bird", "Grace", "M", "06/08/2015", "06/08/2015",},
            new List<string> {"Sea Lions", "insect", "Mia", "M", "29/05/2009", "29/05/2009",},
            new List<string> {"Sea Turtle", "fish", "Poppy", "F", "30/05/2009", "30/05/2009",},
            new List<string> {"Sei Whale", "invertebrate", "Ella", "F", "31/05/2009", "31/05/2009",},
            new List<string> {"Sri Lankan Elephant", "mammal", "George", "M", "01/06/2009", "01/06/2009",},
            new List<string> {"Tiger", "reptile", "Harry", "M", "02/06/2009", "02/06/2009",},
            new List<string> {"Whale", "bird", "Noah", "M", "03/06/2009", "03/06/2009",},
            new List<string> {"Whale Shark", "insect", "Jack", "F", "04/06/2009", "04/06/2009",},
            new List<string> {"Bigeye Tuna", "fish", "Charlie", "F", "05/06/2009", "05/06/2009",},
            new List<string> {"Black Spider Monkey", "invertebrate", "Leo", "F", "06/06/2009", "06/06/2009",},
            new List<string> {"Dugong", "fish", "Jacob", "M", "07/06/2009", "07/06/2009",},
            new List<string> {"Giant Panda", "invertebrate", "Freddie", "F", "08/06/2009", "08/06/2009",},
            new List<string> {"Giant Tortoise", "mammal", "Alfie", "M", "09/06/2009", "09/06/2009",},
            new List<string> {"Addax", "mammal", "Isla", "M", "10/06/2009", "10/06/2009",},
            new List<string> {"Adelie Penguin", "reptile", "Ava", "F", "11/06/2009", "11/06/2009",},
            new List<string> {"Affenpinscher", "bird", "Emily", "F", "12/06/2009", "12/06/2009",},
            new List<string> {"Afghan Hound", "insect", "Sophia", "M", "13/06/2009", "13/06/2009",},
            new List<string> {"African Bullfrog", "fish", "Grace", "M", "14/06/2009", "14/06/2009",},
            new List<string> {"African Bush Elephant", "invertebrate", "Mia", "M", "15/06/2009", "15/06/2009",},
            new List<string> {"African Civet", "fish", "Poppy", "F", "17/02/2017", "17/02/2017",},
            new List<string> {"African Clawed Frog", "invertebrate", "Ella", "F", "18/02/2017", "18/02/2017",},
            new List<string> {"African Forest Elephant", "mammal", "George", "F", "19/02/2017", "19/02/2017",},
            new List<string> {"African Grey Parrot", "reptile", "Harry", "M", "20/02/2017", "20/02/2017",},
            new List<string> {"African Palm Civet", "bird", "Noah", "F", "21/02/2017", "21/02/2017",},
            new List<string> {"African Penguin", "insect", "Jack", "M", "22/02/2017", "22/02/2017",},
            new List<string> {"African Tree Toad", "fish", "Charlie", "M", "23/02/2017", "23/02/2017",},
            new List<string> {"African Wild Dog", "invertebrate", "Leo", "F", "24/02/2017", "24/02/2017",},
            new List<string> {"Aidi", "mammal", "Jacob", "F", "25/02/2017", "25/02/2017",},
            new List<string> {"Ainu", "reptile", "Freddie", "M", "26/02/2017", "26/02/2017",},
            new List<string> {"Airedale Terrier", "bird", "Alfie", "M", "27/02/2017", "27/02/2017",},
            new List<string> {"Airedoodle", "insect", "Isla", "M", "28/02/2017", "28/02/2017",},
            new List<string> {"Akbash", "fish", "Ava", "F", "01/03/2017", "01/03/2017",},
            new List<string> {"Akita", "invertebrate", "Emily", "F", "02/03/2017", "02/03/2017",},
            new List<string> {"Akita Shepherd", "fish", "Sophia", "F", "03/03/2017", "03/03/2017",},
            new List<string> {"Alabai", "invertebrate", "Grace", "M", "04/03/2017", "04/03/2017",},
            new List<string> {"Alaskan Husky", "mammal", "Mia", "F", "05/03/2017", "05/03/2017",},
            new List<string> {"Alaskan Klee Kai", "reptile", "Poppy", "M", "06/03/2017", "06/03/2017",},
            new List<string> {"Alaskan Malamute", "bird", "Ella", "M", "07/03/2017", "07/03/2017",},
            new List<string> {"Alaskan Shepherd", "insect", "George", "F", "08/03/2017", "08/03/2017",},
            new List<string> {"Albacore Tuna", "fish", "Harry", "F", "09/03/2017", "09/03/2017",},
            new List<string> {"Albatross", "invertebrate", "Noah", "M", "10/03/2017", "10/03/2017",},
            new List<string> {"Aldabra Giant Tortoise", "mammal", "Jack", "M", "11/03/2017", "11/03/2017",},
            new List<string> {"Alligator", "reptile", "Charlie", "M", "12/03/2017", "12/03/2017",},
            new List<string> {"Alligator Gar", "bird", "Leo", "F", "13/03/2017", "13/03/2017",},
            new List<string> {"Alpaca", "insect", "Jacob", "F", "14/03/2017", "14/03/2017",},
            new List<string> {"Alpine Dachsbracke", "fish", "Freddie", "F", "15/03/2017", "15/03/2017",},
            new List<string> {"Alpine Goat", "invertebrate", "Alfie", "M", "16/03/2017", "16/03/2017",},
            new List<string> {"Alusky", "fish", "Isla", "F", "17/03/2017", "17/03/2017",},
            new List<string> {"Amazon Parrot", "invertebrate", "Ava", "M", "18/03/2017", "18/03/2017",},
            new List<string>
                {"Amazon River Dolphin (Pink Dolphin)", "mammal", "Emily", "M", "19/03/2017", "19/03/2017",},
            new List<string> {"American Alsatian", "reptile", "Sophia", "F", "20/03/2017", "20/03/2017",},
            new List<string> {"American Bulldog", "bird", "Grace", "F", "21/03/2017", "21/03/2017",},
            new List<string> {"American Cocker Spaniel", "insect", "Mia", "M", "22/03/2017", "22/03/2017",},
            new List<string> {"American Cockroach", "fish", "Poppy", "M", "23/03/2017", "23/03/2017",},
            new List<string> {"American Coonhound", "invertebrate", "Ella", "M", "24/03/2017", "24/03/2017",},
            new List<string> {"American Eskimo Dog", "mammal", "George", "F", "25/03/2017", "25/03/2017",},
            new List<string> {"American Foxhound", "reptile", "Harry", "F", "26/03/2017", "26/03/2017",},
            new List<string> {"American Hairless Terrier", "bird", "Noah", "F", "27/03/2017", "27/03/2017",},
            new List<string> {"American Leopard Hound", "insect", "Jack", "M", "28/03/2017", "28/03/2017",},
            new List<string> {"American Pit Bull Terrier", "fish", "Charlie", "F", "29/03/2017", "29/03/2017",},
            new List<string> {"American Pygmy Goat", "invertebrate", "Leo", "M", "30/03/2017", "30/03/2017",},
            new List<string> {"American Robin", "fish", "Jacob", "M", "31/03/2017", "31/03/2017",},
            new List<string>
                {"American Staffordshire Terrier", "invertebrate", "Freddie", "F", "13/04/1995", "13/04/1995",},
            new List<string> {"American Toad", "mammal", "Alfie", "F", "14/04/1995", "14/04/1995",},
            new List<string> {"American Water Spaniel", "mammal", "Isla", "M", "15/04/1995", "15/04/1995",},
            new List<string> {"Amur Leopard", "reptile", "Ava", "M", "16/04/1995", "16/04/1995",},
            new List<string> {"Anatolian Shepherd Dog", "bird", "Emily", "M", "02/05/2019", "02/05/2019",},
            new List<string> {"Anchovies", "insect", "Sophia", "F", "03/05/2019", "03/05/2019",},
            new List<string> {"Angelfish", "fish", "Grace", "F", "04/05/2019", "04/05/2019",},
            new List<string> {"Anglerfish", "invertebrate", "Mia", "F", "05/05/2019", "05/05/2019",},
            new List<string> {"Angora Goat", "fish", "Poppy", "M", "06/05/2019", "06/05/2019",},
            new List<string> {"Ant", "invertebrate", "Ella", "F", "07/05/2019", "07/05/2019",},
            new List<string> {"Antarctic scale worm", "mammal", "George", "M", "08/05/2019", "08/05/2019",},
            new List<string> {"Anteater", "reptile", "Harry", "M", "09/05/2019", "09/05/2019",},
            new List<string> {"Antelope", "bird", "Noah", "F", "10/05/2019", "10/05/2019",},
            new List<string> {"Appenzeller Dog", "insect", "Jack", "F", "11/05/2019", "11/05/2019",},
            new List<string> {"Apple Head Chihuahua", "fish", "Charlie", "M", "03/05/2018", "03/05/2018",},
            new List<string> {"Arapaima", "invertebrate", "Leo", "M", "04/05/2018", "04/05/2018",},
            new List<string> {"Arctic Fox", "mammal", "Jacob", "M", "05/05/2018", "05/05/2018",},
            new List<string> {"Arctic Hare", "reptile", "Freddie", "F", "06/05/2018", "06/05/2018",},
            new List<string> {"Arctic Wolf", "bird", "Alfie", "F", "07/05/2018", "07/05/2018",},
            new List<string> {"Arizona Bark Scorpion", "insect", "Isla", "F", "08/05/2018", "08/05/2018",},
            new List<string> {"Armadillo", "fish", "Ava", "M", "09/05/2018", "09/05/2018",},
            new List<string> {"Armyworm", "invertebrate", "Emily", "F", "10/05/2018", "10/05/2018",},
            new List<string> {"Asian Elephant", "fish", "Sophia", "M", "11/05/2018", "11/05/2018",},
            new List<string> {"Asian Giant Hornet", "invertebrate", "Grace", "M", "12/05/2018", "12/05/2018",},
            new List<string> {"Asian Palm Civet", "mammal", "Mia", "F", "13/05/2018", "13/05/2018",},
            new List<string> {"Asiatic Black Bear", "reptile", "Poppy", "F", "14/05/2018", "14/05/2018",},
            new List<string> {"Aurochs", "bird", "Ella", "M", "15/05/2018", "15/05/2018",},
            new List<string> {"Aussiedoodle", "insect", "George", "M", "16/05/2018", "16/05/2018",},
            new List<string> {"Aussiedor", "fish", "Harry", "M", "27/07/2015", "27/07/2015",},
            new List<string> {"Australian Bulldog", "invertebrate", "Noah", "F", "28/07/2015", "28/07/2015",},
            new List<string> {"Australian Cattle Dog", "mammal", "Jack", "F", "29/07/2015", "29/07/2015",},
            new List<string> {"Australian Gecko", "reptile", "Charlie", "F", "30/07/2015", "30/07/2015",},
            new List<string> {"Australian Kelpie Dog", "bird", "Leo", "M", "31/07/2015", "31/07/2015",},
            new List<string> {"Australian Labradoodle", "insect", "Jacob", "F", "01/08/2015", "01/08/2015",},
            new List<string> {"Australian Mist", "fish", "Freddie", "M", "02/08/2015", "02/08/2015",},
            new List<string> {"Australian Retriever", "invertebrate", "Alfie", "M", "03/08/2015", "03/08/2015",},
            new List<string> {"Australian Shepherd", "fish", "Ben", "F", "04/08/2015", "04/08/2015",},
            new List<string> {"Australian Terrier", "invertebrate", "Joseph", "F", "05/08/2015", "05/08/2015",},
            new List<string> {"Avocet", "mammal", "Charles", "M", "06/08/2015", "06/08/2015",},
        };
        
        public static int GetAge(DateTime DOB)
        {
            var today = DateTime.Today;
            return today.Year - DOB.Year;
        }
        
        public static IEnumerable<Animal> GetAnimals()
        {
            return Enumerable.Range(0, NumberOfAnimals).Select(CreateRandomAnimal);
        }

        private static Animal CreateRandomAnimal(int index)
        {
            DateTime Dob = DateTime.ParseExact(Data[index][5], "dd/MM/yyyy",
                System.Globalization.CultureInfo.InvariantCulture);
            
            return new Animal
            {
                Species = Data[index][0],
                Classification = Data[index][1],
                Name = Data[index][2],
                Sex = Data[index][3],
                DateAcquired = DateTime.ParseExact(Data[index][4], "dd/MM/yyyy",
                    System.Globalization.CultureInfo.InvariantCulture),
                Dob = Dob,
                Age = GetAge(Dob)
            };
        }
    }
}