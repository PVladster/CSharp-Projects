namespace Module1
{
    internal class CardPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Оплачено карткою: {amount} грн");
        }
    }
}