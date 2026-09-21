namespace Pr1
{
    internal class Task2
    {
        public void Run()
        {
           int[] numbers = new int[10];
           IntializeArrayRandom(numbers);
           PrintArray(numbers);
           Console.WriteLine($"Lenght of the array: {numbers.Length}");
           Console.WriteLine($"Sum of array elements: {SumArray(numbers)}");
           Console.WriteLine($"Average of array: {AverageArray(numbers)}");
           Console.WriteLine($"Min value in array: {FindMin(numbers)}");
           Console.WriteLine($"Max value in array: {FindMax(numbers)}");

           
        }
        public void IntializeArrayRandom(int[] numbers)
        {
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 101);
            }
        }

        public void PrintArray(int[] numbers)
        {
            foreach (int number in numbers)
            {
                Console.WriteLine(number + " ");
            }
            Console.WriteLine();
        }

        public int SumArray(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }
        public double AverageArray(int[] numbers)
        {
            int sum = SumArray(numbers);
            return(double)sum / numbers.Length;
        }
        public int FindMin(int[] numbers)
        {
            int min = numbers[0];
            foreach (int number in numbers)
            {
                if (number< min)
                {
                    min = number;
                }
            }
            return min;
        }
        public int FindMax(int[] numbers)
        {
            return numbers.Max();
        }
    }

}
