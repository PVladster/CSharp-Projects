namespace Module1
{
    internal class Order
    {
       public int Number { get; private set; } 
       public string Description { get; private set; }
       public decimal Weight { get; private set; }
       public decimal Distance { get; private set; }
       public Order(int number, string description, decimal weight, decimal distance)
        {
            if(number <= 0)
            {
                throw new ArgumentException("Номер замовлення повинен бути більшим за нуль.");
            }
            Number = number;

            if(string.IsNullOrWhiteSpace(description))
            {
                throw new ArgumentException("Опис не повинен бути порожнім.");
            }
            Description = description;

            if(weight <= 0)
            {
                throw new ArgumentException("Вага повинна бути більшою за нуль");
            }
            Weight = weight;
            
            if(distance <= 0)
            {
                throw new ArgumentException("Відстань повинна бути більшою за нуль");
            }
            Distance = distance;
        }
    }
}