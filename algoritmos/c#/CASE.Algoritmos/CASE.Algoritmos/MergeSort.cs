namespace CASE.Algoritmos
{
    public class MergeSort
    {
        private void Merge(int[] array, int l, int m, int r)
        {
            var n1 = m - l + 1;
            var n2 = r - m;

            var esquerda = new int[n1];
            var direita = new int[n2];

            for (var a = 0; a < n1; ++a)
            {
                esquerda[a] = array[l + a];
            }

            for (var b = 0; b < n2; ++b)
            {
                direita[b] = array[m + 1 + b];
            }

            int i = 0, j = 0;

            var k = l;
            while (i < n1 && j < n2)
            {
                if (esquerda[i] <= direita[j])
                {
                    array[k] = esquerda[i];
                    i++;
                }
                else
                {
                    array[k] = direita[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                array[k] = esquerda[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                array[k] = direita[j];
                j++;
                k++;
            }
        }

        public void Sort(int[] array, int l, int r)
        {
            if (l < r)
            {
                var m = (l + r) / 2;
                Sort(array, l, m);
                Sort(array, m + 1, r);
                Merge(array, l, m, r);
            }
        }
    }
}
