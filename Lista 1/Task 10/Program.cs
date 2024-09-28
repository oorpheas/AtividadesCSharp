namespace Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomeFuncionario = Console.ReadLine();
            double salarioFixo = double.Parse(Console.ReadLine());
            double totalVendas = double.Parse(Console.ReadLine());
            double salarioFuncionario = salarioFixo + (totalVendas *
            0.15);
            Console.WriteLine($"Funcionário = {nomeFuncionario}");
            Console.WriteLine($"Salário = ${salarioFuncionario:f2}");
        }
    }
}
