namespace Task_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dinheiroInput = int.Parse(Console.ReadLine());

            double dinheiro = dinheiroInput;

            double[] notas = new double[7];

            int[] cedulas = new int[7];
            cedulas[0] = 100;
            cedulas[1] = 50;
            cedulas[2] = 20;
            cedulas[3] = 10;
            cedulas[4] = 5;
            cedulas[5] = 2;
            cedulas[6] = 1;

            for (int i = 0; i < 7; i++ )
            {
                if (dinheiro >= cedulas[i])
                {
                    notas[i] = (Math.Floor(dinheiro / cedulas[i]));
                    dinheiro = (dinheiro - (cedulas[i] * notas[i]));
                }
            }

            Console.WriteLine($"{dinheiroInput}:");

            for (int i = 0; i < 7; i++)
            {
                if ( notas[i] != 0)
                {
                    Console.WriteLine($"{notas[i]} notas de {cedulas[i]}");
                }
            }
        }
    }
}
