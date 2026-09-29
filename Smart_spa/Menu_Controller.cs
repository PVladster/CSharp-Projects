namespace Smart_spa
{
    internal class Menu_Controller
    {
        public static void ShowMainMenu(Client currentClient)
        {
            bool isRunnig = true;
            while (isRunnig)
            {
                Console.Clear();
                Console.WriteLine($"--Smart spa--");
                Console.WriteLine($"Вітаємо, {currentClient.Name}");
                Console.WriteLine("1.Діагностика");
                Console.WriteLine("2.Оплата та знижки");
                Console.WriteLine("3.Інформація для клієнта");
                Console.WriteLine("4.Про розробницю");
                Console.WriteLine("5.Вихід");
                Console.Write("Оберіть пункт меню: ");

                string choise = Console.ReadLine() ?? "";

                switch (choise)
                {
                    case "1":
                    Console.Clear();
                    Console.Write("----Ваша Діагностика----\n");
                    Spa_Service.CalculateBMI(currentClient.Weight, currentClient.Height);
                    Console.WriteLine("\nНатисніть Enter, щоб перейти до вибору процедури...");
                    Console.ReadLine();
                    currentClient.Bill = Spa_Service.ChooseProcedure();
                    Console.WriteLine("Процедуру обрано! Натисніть Enter для повернення до меню");
                    Console.ReadLine();
                    break;
                    
                    case "2":
                    Console.Clear();
                    Console.WriteLine("----Оплата знижки----\n");
                    Spa_Service.CalculateDiskont(currentClient.Bill);
                    Console.WriteLine("Натисніть Enter для повернення до меню");
                    Console.ReadLine();
                    break;
                    
                    case "3":
                    Console.Clear();
                    Console.WriteLine("3.Інформація для клієнта");
                    Spa_Service.InfoForClient();
                    Console.WriteLine("Натисніть Enter для повернення до меню");
                    Console.ReadLine();
                    break;
                    
                    case "4":
                    Console.Clear();
                    Spa_Service.AboutAutor();
                    Console.WriteLine("Натисніть Enter для повернення до меню");
                    Console.ReadLine();
                    break;
                    
                    case "5":
                    Console.Clear();
                    Console.WriteLine("До побачення!");
                    isRunnig = false;
                    break;
                    
                    default:
                    Console.Write("Невірний вибір! Оберіть від 1 до 5 включно");
                    Console.ReadLine();
                    break;

                }
            }
        }
    }
}