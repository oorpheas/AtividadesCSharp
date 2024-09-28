namespace Task_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int carro1 = 60;
            int carro2 = 90;

            int input = int.Parse(Console.ReadLine());

            double distancia = input / 30;
            double distanciaFinal = distancia * 60;

            Console.WriteLine($"{distanciaFinal} minutos");

        }
    }
}
