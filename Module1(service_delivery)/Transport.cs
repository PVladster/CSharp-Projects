namespace Module1
{
   abstract class Transport
    {
        public decimal MaxWeight { get; private set; }
        public bool IsBusy { get; private set; }
        public Transport(decimal maxWeight)
        {
            MaxWeight = maxWeight;
        }
        public abstract decimal CalculateCost(Order order);
        public virtual bool CanTake(Order order)
        {
            return order.Weight <= MaxWeight;
        }
        public void MarkBusy()
        {
            IsBusy = true;
        }
        public void MarkFree()
        {
            IsBusy = false;
        }
    }
}