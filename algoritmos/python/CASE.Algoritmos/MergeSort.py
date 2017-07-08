class MergeSort:
    def merge(self, array, l, m, r):
        n1 = (m - l + 1)
        n2 = r - m

        esquerda = [0] * (n1)
        direita = [0] * (n2)

        for i in range(0, n1):
            esquerda[i] = array[l + i]

        for j in range(0, n2):
            direita[j] = array[m + 1 + j]

        i = 0
        j = 0
        k = l
        while i < n1 and j < n2:
            if esquerda[i] <= direita[j]:
                array[k] = esquerda[i]
                i += 1
            else:
                array[k] = direita[j]
                j += 1
            k += 1

        while i < n1:
            array[k] = esquerda[i]
            i += 1
            k += 1

        while j < n2:
            array[k] = direita[j]
            j += 1
            k += 1


    def sort(self, array, l, r):
        if l < r:
            m = (l + (r - 1)) // 2
            self.sort(array, l, m)
            self.sort(array, m + 1, r)
            self.merge(array, l, m, r)

