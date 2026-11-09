namespace Module1
{
    internal class Car : Transport
    {
        public Car(decimal maxWeight) : base(maxWeight)
        {
        }
        public override decimal CalculateCost(Order order)
        {
            return 50 + 8 * order.Distance + 1 * order.Weight;
        }
    }
}