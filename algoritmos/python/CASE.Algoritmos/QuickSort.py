class QuickSort:

    def partition(self, array, menor, maior):
        i = (menor - 1)
        pivot = array[maior]

        for j in range(menor, maior):
            if array[j] <= pivot:
                i = i + 1
                array[i], array[j] = array[j], array[i]

        array[i + 1], array[maior] = array[maior], array[i + 1]
        return (i + 1)


    def sort(self, array, menor, maior):
        if menor < maior:
            pi = self.partition(array, menor, maior)
            self.sort(array, menor, pi - 1)
            self.sort(array, pi + 1, maior)