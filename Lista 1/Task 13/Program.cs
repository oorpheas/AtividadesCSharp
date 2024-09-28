namespace Task_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());
            double areaTriangulo = ((A * C) / 2);
            double areaCirculo = (3.14159 * (C * C));
            double areaTrapezio = (((A + B) * C) / 2);
            double areaQuadrado = (B * B);
            double areaRetangulo = (A * B);

            Console.WriteLine($"Área do Triângulo: {areaTriangulo}");
            Console.WriteLine($"Área do Círculo: {areaCirculo}");
            Console.WriteLine($"Área do Trapézio: {areaTrapezio}");
            Console.WriteLine($"Área do Quadrado: {areaQuadrado}");
            Console.WriteLine($"Área do Retângulo: {areaRetangulo}");
        }
    }
}
