namespace Task_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pecaUm = int.Parse(Console.ReadLine());
            int numeroPecasUm = int.Parse(Console.ReadLine());
            double valorPecaUm = double.Parse(Console.ReadLine());
            int pecaDois = int.Parse(Console.ReadLine());
            int numeroPecasDois = int.Parse(Console.ReadLine());
            double valorPecaDois = double.Parse(Console.ReadLine());
            double valorFinal = (numeroPecasUm * valorPecaUm) +
            (numeroPecasDois * valorPecaDois);
            Console.WriteLine($"O valor total é de: R${valorFinal:f2}");
        }
    }
}
