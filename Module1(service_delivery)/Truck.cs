namespace Module1
{
    internal class Truck : Transport
    {
        public Truck(decimal maxWeight) : base(maxWeight)
        {
        }
        public override decimal CalculateCost(Order order)
        {
            return 200 + 15 * order.Distance + (decimal)0.5 * order.Weight;
        }
    
    }
}