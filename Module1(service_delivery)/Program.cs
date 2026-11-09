namespace Module1
{
    class Program
    {
        static void Main()
        {
            DeliveryService service = new DeliveryService();
            Transport transport1 = new Bike(15);
            Transport transport2 = new Car(100);
            Transport transport3 = new Truck(1000);
            service.AddTransport(transport1);
            service.AddTransport(transport2);
            service.AddTransport(transport3);

            Order order1 = new Order(1, "Документи", 2, 5);
            Order order2 = new Order(2, "Ноутбук", 8, 15);
            Order order3 = new Order(3, "Меблі", 150,20);
            Order order4 = new Order(4, "Посилка", 20, 8);
            service.AddOrder(order1);
            service.AddOrder(order2);
            service.AddOrder(order3);
            service.AddOrder(order4);

            service.AssignOrder(order1, transport1);
            service.CompleteDelivery(order1, new CardPayment());

            service.AssignOrder(order3, transport2);
            service.CompleteDelivery(order3, new CardPayment());

            Console.WriteLine("++++++++++++++++++++++++++++");
            
            Console.WriteLine("Ціни доставки іншим транспортом:");
            service.ShowAvailableCosts(order2);
            service.AssignOrder(order2, transport3);
            service.CompleteDelivery(order2, new CashPayment());

            Console.WriteLine("++++++++++++++++++++++++++++");

            Console.WriteLine("Активні замовлення:");
            service.ShowActiveOrders();
            Console.WriteLine("Історія доставок:");
            service.ShowDeliveryHistory();

        }
    }
}