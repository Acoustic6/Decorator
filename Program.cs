using System;
using Decorator.src;
using Decorator.src.BaseDrinks;
using Decorator.src.Decorators;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var espresso = new Espresso();
            Console.WriteLine(espresso.GetDescription());
            Console.WriteLine(espresso.Cost());
            var espressoWithChoc = new HotChocolate(espresso);
            Console.WriteLine(espressoWithChoc.GetDescription());
            Console.WriteLine(espressoWithChoc.Cost());
            var espressoWithChockAndDoubleSyrop = 
                new MapleSyrup(new MapleSyrup(espressoWithChoc));
            Console.WriteLine(espressoWithChockAndDoubleSyrop.GetDescription());
            Console.WriteLine(espressoWithChockAndDoubleSyrop.Cost());
        }
    }
}
