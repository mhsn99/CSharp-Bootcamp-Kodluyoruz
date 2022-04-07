using System;
using System.Collections.Generic;

namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> cities = new List<string>() { "Ankara", "Ankara", "Ankara", "Sinop", 
            //    "İstanbul", "İstanbul", "Eskişehir", "Ankara"};

            List<string> cities = new List<string>() { "Manisa", "Ankara", "Ankara", "Sinop",
                "İstanbul", "İstanbul", "Eskişehir", "Ankara","Muğla", "Manisa","Malatya", "Hatay","Erzurum","Hatay",
                "İstanbul","Sinop","Sinop","Eskişehir","Yozgat","Malatya", "Batman", "Muğla","Van"};

            List<string> citiesUnique = new List<string>();

            cities.Sort(); // first, sorting cities names alphabetically

            citiesUnique.Add(cities[0]); // Then, adding first city to the unique cities list.

            foreach (string city in cities) // Loop for checking whether the city is a value of the unique cities list or not.
            {
                if (city != citiesUnique[citiesUnique.Count - 1]) // if the city is not value of the unique cities list.
                {
                    citiesUnique.Add(city); // then, add to the unique cities list.
                }
            }

            foreach (string city in citiesUnique)
            {
                Console.Write($"{city} - ");
            }

        }
    }
}
