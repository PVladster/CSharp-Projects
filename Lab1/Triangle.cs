using System.Data;
using System.Runtime.InteropServices;

namespace Lab1
{
    internal class Triangle
    {
        public bool AreSidesPositive(double a, double b, double c)
        {
           if(a > 0 && b > 0 && c > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsTriangleValid(double a, double b, double c)
        {
            if(a + b > c && a + c > b && b + c > a)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double CalculatePerimeter(double a, double b, double c)
        {
           double sum;
           sum = a + b + c;
           return sum; 
        }
        public double CalculateArea(double a, double b, double c)
        {
            double p = CalculatePerimeter(a,b,c)/2;

            return Math.Sqrt(p*(p - a)*(p - b)* (p - c));
        }
        public string DetermineTriangleType(double a, double b, double c)
        {
            switch(true)
            {
                case true when(a * a + b * b == c * c) || (b * b + c * c == a * a) || (a * a + c * c == b * b):
                return "Прямокутний";
                case true when (a == b && b == c):
                return "Рівностороній";
                case true when(a == b || c == b || a == c):
                return "Рівнобедрений";
                default:
                return "Довільний";
            }
        }
    }
}