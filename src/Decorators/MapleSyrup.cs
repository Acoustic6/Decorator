namespace Decorator.src.Decorators
{
    public class MapleSyrup: CondimentDecorator
    {
        private Beverage beverage;
        public MapleSyrup(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string GetDescription()
        {
            return string.Join(" + ", beverage.GetDescription(), "Maple Syrup");
        }
        public override double Cost()
        {
            return beverage.Cost() + 0.19;
        }
    }
}