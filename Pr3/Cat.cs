namespace Pr3
{
    internal class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} meow");
        }
        public override void Run()
        {
            Console.WriteLine($"{Name} runs gracefully.");
        }
    }
}