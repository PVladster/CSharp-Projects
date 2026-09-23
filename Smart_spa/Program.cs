using System.Security.Cryptography;

namespace Smart_spa
{
    public class Program
    {
        static void Main()
        {
           string name = GetNameFromUser();
           short age = GetAgeFromUser();
           double height = GetHeightFromUser();
           double weight = GetWeightFromUser();
           int lifeStyle = GetLifeStyleFromUser();

           Client client = new Client();
           client.Name = name;
           client.Age = age;
           client.Height = height;
           client.Weight = weight;
           client.LifeStyle = lifeStyle;
        }
        public static string GetNameFromUser()
        {
           Console.Write("Введіть ваше ім'я: ");
           return Console.ReadLine() ?? string.Empty;
        }
        public static short GetAgeFromUser()
        {
            Console.Write("Введіть ваш вік: ");
            short.TryParse(Console.ReadLine(), out short age);
            return age;
        }
        public static double GetHeightFromUser()
        {
            Console.Write("Введіть ваш зріст: ");
            double.TryParse(Console.ReadLine(), out double height);
            return height;
        }
        public static double GetWeightFromUser()
        {
            Console.Write("Введіть вашу вагу: ");
            double.TryParse(Console.ReadLine(), out double weight);
            return weight;
        }
        public static int GetLifeStyleFromUser()
        {
            Console.WriteLine("Вибиріть ваш рівень активності: ");
            Console.WriteLine("1 - Сидячий спосіб життя(мало руху)");
            Console.WriteLine("2 - Помірна активність (прогулянки, спортзал 2 рази на тиждень)");
            Console.WriteLine("3 - Висока активність (професійний спорт)");
            int.TryParse(Console.ReadLine(), out int lifeStyle);
            return lifeStyle;
           }
        }
    }

