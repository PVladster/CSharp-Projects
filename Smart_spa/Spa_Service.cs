using System.Security.Cryptography.X509Certificates;

namespace Smart_spa
{
    internal class Spa_Service
    {
        public static void CalculateBMI(double weight, double height)
    {
       height /= 100;
       double BMI = weight / (height * height);
       Console.Clear();
       Console.WriteLine($"Ваш індекс маси тіла(ІМТ): {Math.Round(BMI, 1)}");
       if(BMI < 18.5)
            {
                Console.WriteLine("Діагноз: У вас недостатня вага");
                Console.WriteLine("Рекомендація: Відвідати нутріціолага");
            }
        else if( BMI >= 18.5 && BMI <= 24.9)
            {
                Console.WriteLine("Діагноз: У вас нормальна вага");
                Console.WriteLine("Рекомендація: Розслабляючий масаж");
            }
            else
            {
                Console.WriteLine("Діагноз: У вас є збиткова вага");
                Console.WriteLine("Рекомендація: Лімфодренажний масаж або спа капсулу");
            }
    }
          public static double ChooseProcedure()
        {
            Console.Clear();
            Console.WriteLine("---Вибір процедури---\n");
            Console.WriteLine("1. Розслабляючий масаж (1000 грн)");
            Console.WriteLine("2. Лімфодренажний масаж (1200 грн)");
            Console.WriteLine("3. Спа капсула (1600 грн)");
            Console.WriteLine("4. Шоколадне обгортання (1500 грн)");
            Console.WriteLine("5. Пілінг тіла морською сіллю (900 грн)");
            Console.WriteLine("6. Комплекс Повний релакс (2500 грн)");
            Console.WriteLine("7. Антицелюлітний масаж  (1350 грн)");
            Console.WriteLine("8. Ендосфера-терапія (1800 грн)");
            Console.WriteLine("9. RF-ліфтинг тіла (2000 грн)");
            Console.WriteLine("10. Електростимуляція (1200 грн)");
            Console.Write("Оберіть процедуру: ");
           
           string choise = Console.ReadLine() ?? "";
           switch(choise)
            {
                case "1":
                return 1000;
                case "2":
                return 1200;
                case "3":
                return 1600;
                case "4":
                return 1500;
                case "5":
                return 900;
                case "6":
                return 2500;
                case "7":
                return 1350;
                case "8":
                return 1800;
                case "9":
                return 2000;
                case "10":
                return 1200;
                default:
                Console.WriteLine("Невірний вибір! Процедуру не обрано");
                return 0;
            }
        }
        public static void CalculateDiskont(double bill)
        {
            Random random = new Random();
            int discont = random.Next(5,21);
            if( bill == 0)
            {
                Console.WriteLine("Ви ще не обрали жодної процедури в розділі (Діагностика)");
                return;
            }
            double discontSUM = bill * discont / 100;
            double price = bill - discontSUM;
            
            Console.Clear();
            Console.WriteLine($"--Розрахунок знижки--");
            Console.WriteLine($"Початкова сума обраної процедури: {bill}");
            Console.WriteLine($"Ваша випадкова знижка: {discont}%");
            Console.WriteLine($"Сума знижки: {discontSUM}");
            Console.WriteLine($"До сплати: {price}");
        }
        public static string InfoForClient()
        {
          Console.Clear();
          Console.WriteLine("Приходьте за 10-15 хвилин до початку процедури, щоб встигнути переодягнутися та розслабитись.");
          Console.WriteLine("Перед сеансом не рекомендується вживати важку їжу за 1-2 години.");
          Console.WriteLine("Питний режим: після спа-процедур корисно випити склянку трав'яного чаю або теплої води.");
          return "Інформацію надано";
        }
        public static string AboutAutor()
        {
            Console.Clear();
            Console.WriteLine("Розробила Панченко Владислава");
            return "Інформацію надано";
        }
    }
}