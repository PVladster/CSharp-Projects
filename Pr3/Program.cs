namespace Pr3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Barsik");
            Cat cat = new Cat("Tysik");
            Ostrich ostrich = new Ostrich("Flightless");

            Animal[] animals = new Animal[] { dog, cat, ostrich };
            foreach (Animal animal in animals)
            {
                animal.ToGetScared();
            }
            ISoundeable[] soundeables = new ISoundeable[] { dog, cat, ostrich };
            foreach(ISoundeable soundeable1 in soundeables)
            {
                soundeable1.MakeSound();
            }

        }
    }
}
    
