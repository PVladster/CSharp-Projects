using System.ComponentModel;

namespace Pr2
{
    internal class Program
    {
        static void Main()
        {
           Calc_Tool tool = new Calc_Tool();
           Random rnd = new Random();
           int groupCount = rnd.Next(3,6);
           Console.WriteLine($"Кількість груп у потоці: {groupCount}\n");
           Console.WriteLine("==============================");

           int[][] gradesOfOneGroup = tool.GeneratorGrades(groupCount);
           for(int i = 0; i < gradesOfOneGroup.Length; i++)
            {
                double average = tool.GetAverage(gradesOfOneGroup[i]);
                int min = tool.GetMin(gradesOfOneGroup[i]);
                int max = tool.GetMax(gradesOfOneGroup[i]);
                Console.WriteLine($"Результат групи №{i + 1}:");
                Console.WriteLine($"Група: {i + 1}, Середній бал: {average}, Мінімальний бал: {min}, Максималиний бал: {max}");
            }
                double absoluteAVG = tool.GetTotalAverage(gradesOfOneGroup);
                int absoluteMIN = tool.GetTotalMin(gradesOfOneGroup);
                int absoluteMAX = tool.GetTotalMax(gradesOfOneGroup);
                Console.WriteLine("==============================");
                Console.WriteLine($"Повний результат по {groupCount} групам:");
                Console.WriteLine($"Середній бал: {absoluteAVG}");
                Console.WriteLine($"Мінімальний бал: {absoluteMIN}");
                Console.WriteLine($"Максималиний бал: {absoluteMAX}");

                Console.ReadLine();

          

        }
    }
}
