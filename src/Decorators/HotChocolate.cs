namespace Decorator.src.Decorators
{
    public class HotChocolate: CondimentDecorator
    {
        private Beverage beverage;
        public HotChocolate(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string GetDescription()
        {
            return string.Join(" + ", beverage.GetDescription(), "Hot Chocolate");
        }
        public override double Cost()
        {
            return beverage.Cost() + 0.29;
        }
    }
}