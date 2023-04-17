using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.Entities
{
    public static class DogShelter
    {
        public static List<Dog> Dogs = new List<Dog>();

        public static void PrintAll()
        {
            foreach (Dog dog in Dogs)
            {
                Console.WriteLine($"Id: {dog.Id} Name: {dog.Name} Color: {dog.Color}. ");
            }
        }

    }
}
