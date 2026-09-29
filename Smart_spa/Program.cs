using System;

namespace Smart_spa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Ласкаво просимо до Smart Spa!");
            
            Client currentClient = new Client();

            Console.Write("Введіть ваше ім'я: ");
            currentClient.Name = Console.ReadLine() ?? "Клієнт";

            Console.Write("Введіть ваш вік: ");
            if (short.TryParse(Console.ReadLine(), out short age)&& age > 1)
                currentClient.Age = age;

            Console.Write("Введіть ваш зріст (см): ");
            if (double.TryParse(Console.ReadLine(), out double height)&& height > 1)
                currentClient.Height = height;

            Console.Write("Введіть вашу вагу (кг): ");
            if (double.TryParse(Console.ReadLine(), out double weight)&& weight > 1)
                currentClient.Weight = weight;

            Console.Write("Введіть ваш спосіб життя 1.(активний),  2.(не туди - не сюди),  3.(пасивний): ");
            if (int.TryParse(Console.ReadLine(), out int lifestyle))
                currentClient.LifeStyle = lifestyle;
                
            Menu_Controller.ShowMainMenu(currentClient);
        }
    }
}