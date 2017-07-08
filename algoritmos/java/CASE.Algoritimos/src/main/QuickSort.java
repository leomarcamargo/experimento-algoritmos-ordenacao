package main;

public class QuickSort
{
	private int partition(int[] array, int menor, int maior)
	{
		int pivot = array[maior]; 
		int i = (menor-1);
		
		for (int j = menor; j < maior; j++)
		{
			if (array[j] <= pivot)
			{
				i++;
				int temp = array[i];
				array[i] = array[j];
				array[j] = temp;
			}
		}

		int temporario = array[i+1];
		array[i+1] = array[maior];
		array[maior] = temporario;

		return i+1;
	}

	public void sort(int[] array, int menor, int maior)
	{
		if (menor < maior)
		{
			int pi = partition(array, menor, maior);
			sort(array, menor, pi-1);
			sort(array, pi+1, maior);
		}
	}
}