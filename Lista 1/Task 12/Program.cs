namespace Task_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            double raio = double.Parse(Console.ReadLine());
            double volume = (4 * pi * (raio * raio * raio)) / 3;
            Console.WriteLine($"VOLUME = {volume}");
        }
    }
}
