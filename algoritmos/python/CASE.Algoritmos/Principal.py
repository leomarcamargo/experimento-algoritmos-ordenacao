from HeapSort import HeapSort
from MergeSort import MergeSort
from QuickSort import QuickSort
from RadixSort import RadixSort
import csv
import time

print('Iniciando a leitura do arquivo')

diretorioArquivo = 'D:/experimento-algoritmos/dataset-dez-milhoes.txt'
valores = []
i = 0
with open(diretorioArquivo, newline='') as arquivo:
     leitor = csv.reader(arquivo, delimiter=';', quotechar='|')
     for linha in leitor:
         valores.append(int(linha[0]))
         i = i+1

print('Leitura do arquivo finalizada')
print(str(len(valores)) + ' : ' +  str(i))

tamanho = len(valores) - 1

print('Iniciando ordenação')

tempoInicial = time.time()

#heapSort = HeapSort()
#heapSort.sort(valores)

#mergeSort = MergeSort()
#mergeSort.sort(valores, 0, tamanho)

#quickSort = QuickSort()
#quickSort.sort(valores, 0, tamanho)

radixSort = RadixSort()
radixSort.sort(valores)

tempoFinal = time.time()

print('Ordenação finalizada')

tempoExecutado = round((tempoFinal - tempoInicial) * 1000, 4)

print('O tempo gasto para ordenar foi de '+tempoExecutado)