namespace Task_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idFuncionario = int.Parse(Console.ReadLine());
            int horasTrabalhadas = int.Parse(Console.ReadLine());
            double valorHora = double.Parse(Console.ReadLine());
            double salarioFuncionario = horasTrabalhadas *
            valorHora;
            Console.WriteLine($"Funcionário = {idFuncionario}");
            Console.WriteLine($"Salário = ${salarioFuncionario:f2}");
        }
    }
}
