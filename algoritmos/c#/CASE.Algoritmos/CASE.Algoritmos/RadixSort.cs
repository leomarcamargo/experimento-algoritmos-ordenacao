namespace CASE.Algoritmos
{
    public class RadixSort
    {
        private int GetMax(int[] array, int n)
        {
            var maximo = array[0];
            for (var i = 1; i < n; i++)
            {
                if (array[i] > maximo)
                {
                    maximo = array[i];
                }
            }
            return maximo;
        }

        private void Radix(int[] array, int n, int exp)
        {
            var saida = new int[n];
            int i;
            var contador = new int[10];
            for (i = 0; i < 10; i++)
            {
                contador[i] = 0;
            }

            for (i = 0; i < n; i++)
            {
                contador[(array[i] / exp) % 10]++;
            }

            for (i = 1; i < 10; i++)
            {
                contador[i] += contador[i - 1];
            }

            for (i = n - 1; i >= 0; i--)
            {
                saida[contador[(array[i] / exp) % 10] - 1] = array[i];
                contador[(array[i] / exp) % 10]--;
            }

            for (i = 0; i < n; i++)
            {
                array[i] = saida[i];
            }
        }

        public void Sort(int[] array)
        {
            var n = array.Length;
            var m = GetMax(array, n);
            for (var exp = 1; m / exp > 0; exp *= 10)
            {
                Radix(array, n, exp);
            }
        }
    }
}
