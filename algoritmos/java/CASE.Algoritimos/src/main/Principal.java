package main;

import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.nio.file.StandardOpenOption;

import org.apache.commons.lang3.time.StopWatch;;

public class Principal 
{
	public static void main(String args[])
    {
		System.out.println("Iniciando a leitura do arquivo");
		
		String diretorioArquivo = "D:/experimento-algoritmos/dataset-dez-milhoes.txt";
        BufferedReader bufferRead = null;
        String linha = "";
        String delimitador = ";";
        int[] valores = new int[10000000];
        int i = 0;
        try {
            bufferRead = new BufferedReader(new FileReader(diretorioArquivo));
            while ((linha = bufferRead.readLine()) != null) {
            	valores[i] = Integer.parseInt(linha.split(delimitador)[0]);
            	i++;
            }
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        } finally {
            if (bufferRead != null) {
                try {
                    bufferRead.close();
                } catch (IOException e) {
                    e.printStackTrace();
                }
            }
        }
        
        System.out.println(i + " : " + valores.length);
        
        System.out.println("Leitura do arquivo finalizada");
        
        int tamanho = valores.length - 1;
        
        System.out.println("Iniciando ordenação");
        StopWatch contabilizarTempo = StopWatch.createStarted();
        
        /*HeapSort heapSort = new HeapSort();
        heapSort.sort(valores);*/
        
        /*MergeSort mergeSort = new MergeSort();
        mergeSort.sort(valores, 0, tamanho);*/
        
        /*QuickSort quickSort = new QuickSort();
        quickSort.sort(valores, 0, tamanho);*/
        
        RadixSort radix = new RadixSort();
        radix.sort(valores);
        
        contabilizarTempo.stop();
        System.out.println("Ordenação finalizada");
        long tempoExecutado = contabilizarTempo.getTime();   
        System.out.println("O tempo gasto para ordenar foi de " + tempoExecutado);
        
        String valor = Long.toString(tempoExecutado) + System.getProperty("line.separator");
        try {
            Files.write(Paths.get("D:/experimento-algoritmos/ordenacao-java.txt"), valor.getBytes(), StandardOpenOption.APPEND);
        }catch (IOException e) {
            e.printStackTrace();
        }
		
		System.out.println("Finalizado");
    }
}
