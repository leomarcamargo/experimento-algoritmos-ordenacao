namespace CASE.Algoritmos
{
    public class HeapSort
    {
        private void Heapify(int[] array, int n, int i)
        {
            var maior = i;
            var l = 2 * i + 1;
            var r = 2 * i + 2;

            if (l < n && array[l] > array[maior])
            {
                maior = l;
            }

            if (r < n && array[r] > array[maior])
            {
                maior = r;
            }

            if (maior != i)
            {
                var swap = array[i];
                array[i] = array[maior];
                array[maior] = swap;
                Heapify(array, n, maior);
            }
        }

        public void Sort(int[] array)
        {
            var n = array.Length;

            for (var i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(array, n, i);
            }

            for (var i = n - 1; i >= 0; i--)
            {
                var temp = array[0];
                array[0] = array[i];
                array[i] = temp;
                Heapify(array, i, 0);
            }
        }
    }
}
