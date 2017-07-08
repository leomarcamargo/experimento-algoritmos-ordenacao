using System;
using System.IO;

namespace CASE.Algoritmos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iniciando a leitura do arquivo");

            var diretorioArquivo = @"D:/experimento-algoritmos/dataset-dez-milhoes.txt";
            var valores = new int[10000000];
            var i = 0;
            using (var arquivo = new StreamReader(File.OpenRead(diretorioArquivo)))
            {
                while (!arquivo.EndOfStream)
                {
                    var linha = arquivo.ReadLine();
                    if (linha != null)
                    {
                        valores[i] = int.Parse(linha.Split(';')[0]);
                        i++;
                    }
                }
            }

            Console.WriteLine(i + " : " + valores.Length);
            Console.WriteLine("Leitura do arquivo finalizada");

            var tamanho = valores.Length - 1;

            Console.WriteLine("Iniciando ordenação");
            var contabilizarTempo = System.Diagnostics.Stopwatch.StartNew();

            /*var heapSort = new HeapSort();
            heapSort.Sort(valores);*/

            /*var mergeSort = new MergeSort();
            mergeSort.Sort(valores, 0, tamanho);*/

            /*var quickSort = new QuickSort();
            quickSort.Sort(valores, 0, tamanho);*/

            var radix = new RadixSort();
            radix.Sort(valores);

            contabilizarTempo.Stop();
            Console.WriteLine("Ordenação finalizada");
            var tempoExecutado = contabilizarTempo.ElapsedMilliseconds;
            Console.WriteLine($"O tempo gasto para ordenar foi de {tempoExecutado}");

            File.AppendAllLines(@"D:/experimento-algoritmos/ordenacao-csharp.txt", new []{ tempoExecutado.ToString()});
            Console.WriteLine("Finalizado");
            Console.ReadKey();
        }
    }
}
