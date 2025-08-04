class Solution(object):
    fruits = []

    def count_fruits(self, start):
        counter = 1
        types = [self.fruits[start]]
        for i in range(start + 1, len(self.fruits)):
            fruit = self.fruits[i]
            if fruit not in types:
                types.append(fruit)
                if len(types) > 2:
                    return counter
            counter += 1
        return counter


    def totalFruit(self, fruits):
        self.fruits = fruits
        result = max(0, self.count_fruits(0))
        types = [fruits[0]]
        for i in range(1, len(fruits)):
            if fruits[i] not in types:
                result = max(result, self.count_fruits(i-1))
                result = max(result, self.count_fruits(i))
                if len(types) == 2:
                    types.pop(0)
                types.append(fruits[i])

        return result

fruits = [1,1,6,5,6,6,1,1,1,1]
s = Solution()
print(s.totalFruit(fruits))