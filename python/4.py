# 2561
class Solution(object):
    counter = {}

    def addToCounter(self, x, oper):
        if x in self.counter:
            self.counter[x] += oper
        else:
            self.counter[x] = oper

    def minCost(self, basket1, basket2):
        minimum = min(min(basket1), min(basket2))
        for x in basket1:
            self.addToCounter(x, 1)
        for y in basket2:
            self.addToCounter(y, -1)

        merge = []
        for key, el_count in self.counter.items():
            if el_count % 2 != 0:
                return -1
            merge.extend([key] * abs(el_count // 2))

        if not merge:
            return 0

        merge.sort()
        return sum(min(2 * minimum, x) for x in merge[: len(merge) // 2])

arr1 = [4, 2, 2, 2]
arr2 = [1, 4, 1 ,2]
s = Solution()
print(s.minCost(arr1, arr2))