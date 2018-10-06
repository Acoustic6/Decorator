namespace Decorator.src.BaseDrinks
{
    public class Decoffeinato : Beverage
    {
        public override string GetDescription()
        {
            return "Decoffeinato";
        }

        public override double Cost()
        {
            return 1.79;
        }
    }
}