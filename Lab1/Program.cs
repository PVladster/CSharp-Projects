namespace Lab1
{
    internal class Program
    {
        static void Main()
        {
           double a = GetSideFromUser("a");
           double b = GetSideFromUser("b");
           double c = GetSideFromUser("c");

           Triangle triangle = new Triangle();
           if(triangle.AreSidesPositive(a,b,c) && triangle.IsTriangleValid(a,b,c))
            {
                double perimeter = triangle.CalculatePerimeter(a,b,c);
                double area = triangle.CalculateArea(a,b,c);
                string type = triangle.DetermineTriangleType(a,b,c);

                Console.WriteLine($"Perimeter: {perimeter}");
                Console.WriteLine($"Area: {area}");
                Console.WriteLine($"Type of triangle: {type}");
            }
            else
            {
                Console.WriteLine("Error: sides not possitive or triangle not be avalable");
            }
        }
        static double GetSideFromUser(string sideName)
        {
           double result;
            do
            {
                Console.Write($"Enter side {sideName}: ");
            } while(!double.TryParse(Console.ReadLine(), out result));
            return result;
        }
    }
}
