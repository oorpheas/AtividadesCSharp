namespace Task_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());
            if (A > B && A > C)
            {
                Console.WriteLine($"{A} é Maior");
            }
            else if (B > C)
            {
                Console.WriteLine($"{B} é Maior");
            }
            else
            {
                Console.WriteLine($"{C} é Maior");
            }
        }
    }

}
