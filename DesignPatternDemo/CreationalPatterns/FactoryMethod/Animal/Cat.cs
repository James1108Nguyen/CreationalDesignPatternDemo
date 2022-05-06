using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Animal
{
    class Cat : IAnimal
    {
        public string GetName()
        {
            return "I am Cat";    
        }
    }
}
