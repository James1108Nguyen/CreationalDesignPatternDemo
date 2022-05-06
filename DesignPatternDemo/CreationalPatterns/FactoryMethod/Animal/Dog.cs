using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Animal
{
    class Dog : IAnimal
    {
        public string GetName()
        {
            return "I am Dog";
        }
    }
}
