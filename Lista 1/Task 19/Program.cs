namespace Task_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dinheiroInput = int.Parse(Console.ReadLine());

            double dinheiro = dinheiroInput;
            double[] notas = new double[7];

            int[] cedulas = [100, 50, 20, 10, 5, 2, 1];

            Console.WriteLine($"{dinheiroInput}:");

            for (int i = 0; i < 7; i++)
            {
                if (dinheiro >= cedulas[i])
                {
                    notas[i] = (Math.Floor(dinheiro / cedulas[i]));
                    dinheiro = (dinheiro - (cedulas[i] * notas[i]));
                }

                if (notas[i] != 0)
                {
                    Console.WriteLine($"{notas[i]} notas de {cedulas[i]}");
                }
            }
        }
    }
}
