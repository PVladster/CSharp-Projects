namespace Module1
{
    internal class CashPayment: IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Оплачено готівкою: {amount} грн");
        }
    }
}