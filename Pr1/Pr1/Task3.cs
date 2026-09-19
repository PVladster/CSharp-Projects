namespace Pr1
{
    internal class Task3
    {
        public void Run()
        {
          //if (input != null)
            //{
            //    int number = int.Parse(input);
            //    Console.WriteLine($"The number is: {number}");
            //}

            //int result;
            do
            {
                Console.WriteLine("Enter number: ");
            } while(!int.TryParse(Console.ReadLine(), out int result));
        }
    }
}
