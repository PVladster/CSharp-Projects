using System.Globalization;

namespace Lab2Hunter_Game
{
    internal class Game
    {
        public void Start()
        {
            Console.WriteLine("Гру розпочато!");
            Hunter hunter1 = new Hunter("Ben", 100, 50, 10);
            Hunter hunter2 = new Hunter("Wiwi", 100, 50, 10);
            
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("===== МИСЛИВЕЦЬ =====");

                Console.WriteLine("1. Полювання ");
                Console.WriteLine("2. Купити стріли");
                Console.WriteLine("3. Переглянути інформацію");
                Console.WriteLine("4. Вийти");
                
                Console.WriteLine("Оберіть дію: ");
                string? choice = Console.ReadLine();
                Console.WriteLine($"Ваш вибір: {choice}");
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Полювати");
                        Console.WriteLine("1. Ben");
                        Console.WriteLine("2. Wiwi");
                        string? huntChoice = Console.ReadLine();
                        if (huntChoice =="1")
                            {
                            hunter1.Hunt();
                            }
                            else if (huntChoice == "2")
                            {
                                hunter2.Hunt();
                            }
                            else
                            {
                                Console.WriteLine("Невідомий мисливець");
                            }
                        break;
                    case "2":
                        Console.WriteLine("Купити стріли");
                        Console.WriteLine("1. Ben");
                        Console.WriteLine("2. Wiwi");
                        string? hunterChoice = Console.ReadLine();

                        Console.WriteLine("Скільки стріл хочете купити?");
                        string? input = Console.ReadLine();
                        bool success = int.TryParse(input, out int number);
                        if (success && number > 0)
                        {
                            if (hunterChoice == "1")
                            {
                                hunter1.BuyArrow(number);
                            }
                            else if (hunterChoice == "2")
                            {
                                hunter2.BuyArrow(number);
                            }
                            else
                            {
                                Console.WriteLine("Невідомий мисливець");
                            }
                        }else{
                            Console.WriteLine("Помилка");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Переглянути інформацію");
                        hunter1.ShowInfo();
                        hunter2.ShowInfo();
                        break;
                    case "4":
                        Console.WriteLine("Вийти");
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Невідома команда");
                        break;
                }
            }
            if (hunter1.Prey > hunter2.Prey)
            {

                Console.WriteLine("Виграв Ben");
            }
            else if (hunter1.Prey < hunter2.Prey)
            {
                Console.WriteLine("Виграв Wiwi");
            }
            else
            {
                Console.WriteLine("Нічия!");
            }

        }
    }
}