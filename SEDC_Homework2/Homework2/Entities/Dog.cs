using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.Entities
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public Dog(int id, string name, string color)
        { 
            Id = id;
            Name = name;
            Color = color;
        }

        public void Bark()
        {
            Console.WriteLine("Bark Bark! ");
        }

        public static bool Validate(Dog dog)
        {
            if(dog == null)
            {
                return false;
            }
            if(dog.Id < 0 || string.IsNullOrEmpty(dog.Name) || dog.Name.Length <= 2 || string.IsNullOrEmpty(dog.Color) ) 
            {
                return false;
            }
            return true;
        }
    }
}
