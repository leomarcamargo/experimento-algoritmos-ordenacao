package main;
 
public class RadixSort 
{
    private int getMax(int[] array, int n)
    {
        int maximo = array[0];
        for (int i = 1; i < n; i++)
        {
        	 if (array[i] > maximo)
        	 {
        		 maximo = array[i];
        	 }
        }
        return maximo;
    }
 
    private void radix(int[] array, int n, int exp)
    {
        int[] saida = new int[n];
        int i;
        int[] contador = new int[10];

        for (i = 0; i < 10; i++)
        {
            contador[i] = 0;
        }
        
        for (i = 0; i < n; i++)
        {
        	contador[ (array[i]/exp)%10 ]++;
        }
            
        for (i = 1; i < 10; i++)
        {
        	contador[i] += contador[i - 1];
        }
 
        for (i = n - 1; i >= 0; i--)
        {
            saida[contador[ (array[i]/exp)%10 ] - 1] = array[i];
            contador[ (array[i]/exp)%10 ]--;
        }
 
        for (i = 0; i < n; i++)
        {
        	array[i] = saida[i];
        }
    }
 
    public void sort(int[] array)
    {
    	int n = array.length;
        int m = getMax(array, n);
        for (int exp = 1; m/exp > 0; exp *= 10)
        {
        	radix(array, n, exp);
        }
    }
}
