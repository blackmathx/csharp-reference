using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Reference
{
    class Animal
    {
        public string? Name;
        public DateTime Born;
        public byte Legs;
    }
    class Cat : Animal
    {
        public bool IsDomestic;
    }

    class Spider : Animal
    {
        public bool IsPoisonous;
    }


    class _H_Classes
    {
        public static void runner()
        {
            Animal?[] animals = new Animal?[]
            {
                new Cat {Name = "Ozzie", Born = new (year: 2017, month: 7, day: 19), Legs = 4, IsDomestic = true},
                new Spider { Name = "Sid", Born = DateTime.Today, IsPoisonous = true }
            };
            
            foreach (Animal? animal in animals)
            {
                Console.WriteLine($"Name: {animal.Name}");
            }

        }
    }
}
