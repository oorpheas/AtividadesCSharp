namespace Task_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tempo = int.Parse(Console.ReadLine());
            int velMedia = int.Parse(Console.ReadLine());

            int quantiNecessaria = tempo * velMedia;
            int consumo = quantiNecessaria / 12;

            Console.WriteLine($"{consumo:f3}L");
        }
    }
}
