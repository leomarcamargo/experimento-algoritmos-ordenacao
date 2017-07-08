namespace CASE.Algoritmos
{
    public class QuickSort
    {
        private int Partition(int[] array, int menor, int maior)
        {
            var pivot = array[maior];
            var i = (menor - 1);

            for (var j = menor; j < maior; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    var temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

            var temporario = array[i + 1];
            array[i + 1] = array[maior];
            array[maior] = temporario;

            return i + 1;
        }

        public void Sort(int[] array, int menor, int maior)
        {
            if (menor < maior)
            {
                var pi = Partition(array, menor, maior);
                Sort(array, menor, pi - 1);
                Sort(array, pi + 1, maior);
            }
        }
    }
}