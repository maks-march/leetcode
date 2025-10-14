class Solution:
    length = 0
    fruits = []

    def copyFruits(self):
        return [ [x for x in self.fruits[y]] for y in range(0, self.length) ]

    def buildTable(self, stepX, stepY, startX, endX, indexX, startY, endY, indexY):
        table = self.copyFruits()
        for i in range(startX, endX, stepX):
            table[startY + indexY][i] += table[startY+ indexY][i + indexX]
        for j in range(startY, endY, stepY):
            table[j][startX + indexX] += table[j + indexY][startX + indexX]

        for j in range(startY, endY, stepY):
            for i in range(startX, endX, stepX):
                table[j][i] += max(table[j][i + indexX], table[j + indexY][i])
        print(table)
        return table[endY + indexY][endX + indexX]

    def maxCollectedFruits(self, fruits):
        self.length = len(fruits)
        self.fruits = fruits
        result = self.buildTable(
            1, 1,
            1, self.length, -1,
            1, self.length, -1)
        result = max(result, self.buildTable(
            -1, 1,
            self.length-2, -1, 1,
            1, self.length, -1))
        result = max(result, self.buildTable(
            -1, -1,
            self.length - 2, -1, 1,
            self.length - 2, -1, 1))
        result = max(result, self.buildTable(
            1, -1,
            1, self.length, -1,
            self.length - 2, -1, 1))
        return result
s = Solution()
s.maxCollectedFruits([[1,2,3,4],[5,6,8,7],[9,10,11,12],[13,14,15,16]])