using System.ComponentModel.Design;

namespace Torre_de_Hanoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Declare a quantidade de discos presente no desafio");
            int discos = int.Parse(Console.ReadLine()); // recebe o numero de discos

            foreach (var movimento in Hanoi(discos, '1', '2', '3')) // realiza a impressão da resposta
            {
                Console.WriteLine($"Mova o disco {movimento.Item1} da haste {movimento.Item2} para a {movimento.Item3}");
            }
        }

        static public List<Tuple<int, char, char>> Hanoi (int discos, char pilarInicial, char pilarAuxiliar, char pilarFinal)
        {
            // uma tuple é uma "vasilha", capaz de armazenar mais de um valor na mesma variavel

            var solucao = new List<Tuple<int, char, char>>(); // cria uma lista para armazenar as instruções

            if (discos == 1) // caso seja um, a resposta é a mais simples e é filtrada.
            {
                solucao.Add(new Tuple<int, char, char>(discos, pilarInicial, pilarFinal));

                return solucao;
            }

            solucao.AddRange(Hanoi(discos - 1, pilarInicial, pilarFinal, pilarAuxiliar)); // inicia o método
            solucao.Add(new Tuple<int, char, char> (discos, pilarInicial, pilarFinal)); // declara os itens da lista
            solucao.AddRange(Hanoi(discos - 1, pilarAuxiliar, pilarInicial, pilarFinal)); // utiliza o auxiliar para salvar valor e retorna

            /* em AddRange "uma matriz de cadeias de caracteres é criada e passada para o construtor,
            preenchendo a lista com os elementos da matriz" */

            return solucao; // retorna os resultados preenchidos
        }
    }
}
