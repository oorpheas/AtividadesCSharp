namespace Task_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A = int.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double consumoTotal = A / B;
            Console.WriteLine($"{consumoTotal:f3}km/l");
        }
    }
}
