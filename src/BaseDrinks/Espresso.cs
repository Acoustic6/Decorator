namespace Decorator.src.BaseDrinks
{
    public class Espresso : Beverage
    {
        public override string GetDescription()
        {
            return "Espresso";
        }

        public override double Cost()
        {
            return 1.62;
        }
    }
}