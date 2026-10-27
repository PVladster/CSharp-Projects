
namespace Lab3Hunter_Game2_0
{
    internal class Game
    {
        public void Start()
        {
            Console.WriteLine("Гру розпочато!");

            Hunter hunter1 = new Archer("Ben", 100, 50, 10);
            Hunter hunter2 = new Warrior("Wiwi", 100, 50, 10);

            bool isRunning = true;

            while (isRunning)
            {
                Console.Clear();

                Console.WriteLine("===== МИСЛИВЕЦЬ =====");
                Console.WriteLine("1. Полювання");
                Console.WriteLine("2. Купити стріли");
                Console.WriteLine("3. Переглянути інформацію");
                Console.WriteLine("4. Вийти");
                Console.WriteLine("5. Лікування");

                Console.WriteLine("Оберіть дію: ");
                string? choice = Console.ReadLine();

                Console.WriteLine($"Ваш вибір: {choice}");

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Полювати");

                        string? huntChoice = ChooseHunter();

                        if (huntChoice == "1")
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

                        string? hunterChoice = ChooseHunter();

                        if (hunterChoice != "1" && hunterChoice != "2")
                        {
                            Console.WriteLine("Невідомий мисливець");
                            break;
                        }

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
                        }
                        else
                        {
                            Console.WriteLine("Некоректна кількість стріл");
                        }
                        break;

                    case "3":
                        Console.WriteLine("Переглянути інформацію");

                        hunter1.ShowInfo();
                        hunter1.ShowSpecialAbility();

                        Console.WriteLine();

                        hunter2.ShowInfo();
                        hunter2.ShowSpecialAbility();
                        break;

                    case "4":
                        Console.WriteLine("Вийти");
                        isRunning = false;
                        break;

                    case "5":
                        Console.WriteLine("Лікування мисливця");

                        string? healChoice = ChooseHunter();

                        if (healChoice == "1")
                        {
                            hunter1.Heal();
                        }else if (healChoice == "2")
                        {
                            hunter2.Heal();
                        }else{
                            Console.WriteLine("Невідомий мисливець");
                        }
                        break;

                    default:
                        Console.WriteLine("Невідома команда");
                        break;
                }
                if (isRunning)
                {
                    Console.WriteLine("Натисніть Enter, щоб продовжити...");
                    Console.ReadLine();
                }
            }

            Console.Clear();
            Console.WriteLine(" --РЕЗУЛЬТАТ ГРИ--");

            hunter1.ShowInfo();
            Console.WriteLine();
            hunter2.ShowInfo();

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

        private string? ChooseHunter()
        {
            Console.WriteLine("1. Ben");
            Console.WriteLine("2. Wiwi");

            string? choice = Console.ReadLine();
            return choice;
        }
    }
}
