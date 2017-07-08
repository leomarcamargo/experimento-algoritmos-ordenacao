package main;

public class MergeSort
{
	private void merge(int[] array, int l, int m, int r)
	{
		int n1 = m - l + 1;
		int n2 = r - m;

		int[] esquerda = new int [n1];
		int[] direita = new int [n2];

		for (int a = 0; a < n1; ++a)
        {
            esquerda[a] = array[l + a];
        }

        for (int b = 0; b < n2; ++b)
        {
            direita[b] = array[m + 1 + b];
        }

		int i = 0, j = 0;

		int k = l;
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

	public void sort(int[] array, int l, int r)
	{
		if (l < r)
		{
			int m = (l+r)/2;
			sort(array, l, m);
			sort(array , m+1, r);
			merge(array, l, m, r);
		}
	}
}