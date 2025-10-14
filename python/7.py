class Solution(object):
    def numOfUnplacedFruits(self, fruits, baskets):
        result = 0
        available = set(range(0, len(baskets)))
        for fruit in fruits:
            isPlaced = False
            for i, index in enumerate(available):
                basket = baskets[index]
                print(fruit, basket)
                if basket >= fruit:
                    isPlaced = True
                    available.remove(index)
                    break
            if not isPlaced:
                result += 1

        return result

arr = [3,6,1]
baskets = [6, 4, 7]
s = Solution()
print(s.numOfUnplacedFruits(arr, baskets))