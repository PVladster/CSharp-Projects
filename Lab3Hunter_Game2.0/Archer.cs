using System.Security.Cryptography.X509Certificates;

namespace Lab3Hunter_Game2_0
{
    class Archer : Hunter, IHealable
    {
        public Archer(string name, int health, int gold, int arrow) : base(name, health, gold, arrow)
        {
        }
        public override void Hunt()
        {
            Console.WriteLine("Лучник вирушає на полювання!");
            base.Hunt();
        }
        protected override int GetSuccessChance()
        {
            return 75;
        }
        public override void ShowSpecialAbility()
        {
            Console.WriteLine("Особливість лучника: підвищений шанс полювання — 75%");
        }
    }
}