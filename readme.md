# Análise do tempo de execução de algoritmos de ordenação em diferentes linguagens de programação

Esse pequeno experimento visou analisar o tempo de execução de quatro algoritmos de ordenação implementados em três diferentes linguagens de programação. Os algoritmos escolhidos foram:

 * Heap Sort
 * Merge Sort
 * Quick Sort
 * Radix Sort

Cada algoritmo acima foi implementado com as mesmas caracterísitcas nas seguintes linguagens:

* C#  
* Java
* Python

Para avaliar o tempo de execução de cada algoritmo, utilizou-se um *dataset* contendo **10.000.000** de números inteiros aleatórios, no intervalo de **1** a **2.147.483.647**. Esse *dataset* encontra-se em: https://goo.gl/9wK36B.

### Estrutura do repositório


* **algoritmos**: contém o projeto de implementação de cada algoritmo de ordenação nas diferentes linguagens;
	* **c#**: contém o projeto desenvolvido no *Visual Studio 2017 Community*;
	* **java**: contém o projeto desenvolvido no *Eclipse Java Neon*;
	* **python**: contém o projeto desenvolvido na *IDE Pycharm Community*;

* **arquivos**: contém a planilha excel com todos os dados coletados e os testes de hipóteses realizados, além de um arquivo *pdf* com a apresentação dos resultados;