namespace Module1
{
    internal class DeliveryService
    {
        private List<Transport> transports = new List<Transport>();
        private List<Order> activeOrder = new List<Order>();
        private List<Order> deliveryHistory = new List<Order>();
        private Dictionary<Order, Transport> assignments = new Dictionary<Order, Transport>();
        public void AddTransport(Transport transport)
        {
            transports.Add(transport);
        }
        public void AddOrder(Order order)
        {
            if (activeOrder.Any(o => o.Number == order.Number) || deliveryHistory.Any(o => o.Number == order.Number))
            {
                Console.WriteLine("Номер с таким замовленням вже існує!");
                return;
            }
            else
            {
                activeOrder.Add(order);
            }
        }
        public void AssignOrder(Order order, Transport transport)
        {
            if (!transports.Contains(transport))
            {
                Console.WriteLine("Транспорт не зареєстрований");
                return;
            }
            if (!activeOrder.Contains(order))
            {
                Console.WriteLine("Замовлення не зареєстроване");
                return;
            }
            if (transport.IsBusy)
            {
                Console.WriteLine("Транспорт вже зайнятий");
                return;
            }

            if (transport.CanTake(order) == false)
            {
                Console.WriteLine("Транспорт не може перевезти це замовлення");
                return;
            }
            if (assignments.ContainsKey(order))
            {
                Console.WriteLine("Це замовлення вже призначене");
                return;
            }
            assignments.Add(order, transport);
            transport.MarkBusy();
        }
        public void CompleteDelivery(Order order, IPayment payment)
        {
            if (!assignments.ContainsKey(order))
            {
                Console.WriteLine("Замовлення не знайдено");
                return;
            }
            Transport transport = assignments[order];
            decimal cost = transport.CalculateCost(order);
            payment.Pay(cost);
            transport.MarkFree();
            assignments.Remove(order);
            activeOrder.Remove(order);
            deliveryHistory.Add(order);
        }
        public void ShowActiveOrders()
        {
            foreach (Order order in activeOrder)
            {
                Console.WriteLine($"№{order.Number}, {order.Description}, {order.Weight} кг, {order.Distance} км");
            }
        }
        public void ShowDeliveryHistory()
        {
            foreach (Order order in deliveryHistory)
            {
                Console.WriteLine($"№{order.Number}, {order.Description}, {order.Weight} кг, {order.Distance} км");
            }
        }
        public void ShowAvailableCosts(Order order)
        {
            foreach (Transport transport in transports)
            {
                if (transport.CanTake(order))
                {
                   Console.WriteLine($"{transport.GetType().Name}: {transport.CalculateCost(order)} грн");
                   
                }
            }
        }
    }
}