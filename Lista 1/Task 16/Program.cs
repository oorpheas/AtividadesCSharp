namespace Task_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputCorrigido = input.Split(' ');

            double x1 = double.Parse(inputCorrigido[0]);
            double x2 = double.Parse(inputCorrigido[1]);

            input = Console.ReadLine();
            inputCorrigido = input.Split(' ');

            double y1 = double.Parse(inputCorrigido[0]);
            double y2 = double.Parse(inputCorrigido[1]);

            double distancia = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));

            Console.WriteLine($"{distancia:f4}");
        }
    }
}
