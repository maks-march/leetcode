class Solution:
    def getDigits(self, n):
        result = [int(x) for x in str(n)]
        result.sort()
        return result

    def getDigitLength(self, n):
        return len(str(n))

    def reorderedPowerOf2(self, n):
        digits = self.getDigits(n)
        length = self.getDigitLength(n)
        pow = 1
        while self.getDigitLength(pow) < length:
            pow *= 2
        while self.getDigitLength(pow) == length:
            pow_digits = self.getDigits(pow)
            if pow_digits == digits:
                return True
            pow *= 2
        return False
s = Solution()
print(s.reorderedPowerOf2(1))