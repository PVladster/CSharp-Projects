namespace Lab3Hunter_Game2_0
{
    class Warrior : Hunter, IHealable
{
        public Warrior(string name, int health, int gold, int arrow)
            : base(name, health, gold, arrow)
        {
        }
        public override void ShowSpecialAbility()
        {
            Console.WriteLine($"Особливість воїна: стандартний шанс полювання — {GetSuccessChance()}%");
            Console.WriteLine($"Втрата здоров'я за полювання: {GetHealthLoss()}");
        }
        protected override int GetHealthLoss()
        {
            return 5;
        }
}
    }
