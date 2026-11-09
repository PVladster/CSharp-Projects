namespace Module1;

internal class Bike : Transport
{  public Bike(decimal maxWeight) : base(maxWeight)
    {
    }
    public override bool CanTake(Order order)
    {
        return base.CanTake(order) && order.Distance <= 10;
    }
    public override decimal CalculateCost(Order order)
    {
        return 20 + 5 * order.Distance;
    }
  
  
}