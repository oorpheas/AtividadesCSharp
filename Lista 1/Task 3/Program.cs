namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            double raio = double.Parse(Console.ReadLine());
            double area = pi * (raio * raio);
            Console.WriteLine($"A = {area:f4}");
        }
    }
}
