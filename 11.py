class Solution:
    max_multiply = 10**9 + 7

    def productQueries(self, n, queries):
        powers = [1]
        while powers[-1] * 2 <= n:
            powers.append(powers[-1] * 2)
        preMultiply = [1]*len(powers)
        for i in range(1, len(powers)):
            preMultiply[i] = (powers[i] * preMultiply[i-1]) % self.max_multiply
        answers = []
        for start, end in queries:
            if end == start:
                result = powers[end]
            else:
                result = int(preMultiply[end] / preMultiply[start])
            answers.append(result)
            print(answers)
        return answers
s = Solution()
s.productQueries(2, [[0, 0]])