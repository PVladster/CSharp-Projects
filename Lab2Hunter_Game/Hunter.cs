using System.Dynamic;
using System.IO.Pipelines;

namespace Lab2Hunter_Game
{
    internal class Hunter
    {
        public string Name { get; private set; }
        public int Health { get; private set; }
        public int Gold { get; private set; }
        public int Arrow { get; private set; }
        public int Prey{ get; private set; }
        public Hunter(string name, int health, int gold, int arrow)
        {
            Name = name;
            Health = health;
            Gold = gold;
            Arrow = arrow;
        }
        public void Hunt()
        {
            if (Arrow > 0 && Health > 0)
            {
                Console.WriteLine("Мисливець вирушив на полювання!");
                Arrow--;
                Console.WriteLine("-1 стріла");

                int result = Random.Shared.Next(0, 2);
                if (result == 1)
                {
                    Prey++;
                    Console.WriteLine("+1 здобич");
                    Gold += 15;
                    Console.WriteLine("Отриманно +15 золота");
                }
                else
                {
                    Console.WriteLine("Hевдале полювання");
                }
                Health = Math.Max(0, Health - 10);
            }
            else
            {
                Console.WriteLine("Полювання неможливе");
            }
        }
        public void BuyArrow(int arrow)
        {
            int totalCost = arrow * 5;
            if (Gold >= totalCost && arrow > 0)
            {
                Gold -= totalCost;
                Arrow += arrow;
            }
            else
            {
                Console.WriteLine("Не вистачає золота на покупку стріл");
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Ім'я: {Name}");
            Console.WriteLine($"Здоров'я: {Health}");
            Console.WriteLine($"Золото: {Gold}");
            Console.WriteLine($"Запас стріл: {Arrow}");
            Console.WriteLine($"Спіймано здобичі: {Prey}");
            
        }
    }
}