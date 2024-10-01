using System.ComponentModel.Design;

namespace Torre_de_Hanoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Declare a quantidade de discos presente no desafio");
            int discos = int.Parse(Console.ReadLine()); // recebe o numero de discos

            foreach (var item in Hanoi(discos, '1', '2', '3')) // realiza a impressão da resposta
            {
                Console.WriteLine(item);
            }
        }

        static private List<Tuple<char, char>> Hanoi (int discos, char pilarInicial, char pilarAuxiliar, char pilarFinal)
        {
            var solucao = new List<Tuple<char, char>>(); // crio uma lista

            if (discos == 2) // caso seja dois, a resposta é a mais simples e é filtrada.
            { 
                solucao.Add(new Tuple<char, char>(pilarInicial, pilarAuxiliar));
                solucao.Add(new Tuple<char, char>(pilarInicial, pilarFinal));
                solucao.Add(new Tuple<char, char>(pilarAuxiliar, pilarFinal));

                return solucao;
            }

            solucao = Hanoi(discos - 1, pilarInicial, pilarFinal, pilarAuxiliar); // declaro os itens da lista
            solucao.Add(new Tuple<char, char> (pilarInicial, pilarFinal));
            solucao.AddRange(Hanoi(discos - 1, pilarAuxiliar, pilarInicial, pilarFinal));

            /* em AddRange "uma matriz de cadeias de caracteres é criada e passada para o construtor,
            preenchendo a lista com os elementos da matriz" */

            return solucao; // retorna os resultados preenchidos
        }
    }
}
