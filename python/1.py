# 2558
class Solution(object):
    nums = []

    def lengthNums(self):
        return len(self.nums)

    def toBinary(self, num):
        result = ""
        while num > 0:
            result = str(num % 2) + result
            num //= 2
        return result

    def getReversedBits(self, num):
        binaryForm = self.toBinary(num)
        mask = (1 << len(binaryForm)) - 1
        return mask ^ num

    def getBitwiseAnd(self, array):
        result = array[0]
        for i in range(1, len(array)):
            result = result & array[i]
        return result

    def getSubArray(self, prefix, length):
        suffix = -(self.lengthNums() - length - prefix)
        if suffix == 0:
            return self.nums[prefix:]
        else:
            return self.nums[prefix: suffix]

    def subArraysPath(self, maximumBitwise):
        for prefix in range(0, self.lengthNums()):
            for length in range(1, self.lengthNums()+1):
                if prefix + length > self.lengthNums():
                    continue
                subArr = self.getSubArray(prefix, length)
                bitwise = self.getBitwiseAnd(subArr)
                if bitwise == maximumBitwise and len(subArr) > k:
                    k = len(subArr)

    def longestSubarray(self, nums):
        self.nums = nums
        maximumBitwise = max(self.nums)
        maximums = [i for i, x in enumerate(self.nums) if x == maximumBitwise]
        excepted = [i for i, x in enumerate(self.nums) if x & maximumBitwise != maximumBitwise]

        result = 0
        if len(excepted) == 0:
            return len(self.nums)
        if any(i < excepted[0] for i in maximums):
            result = max(result, excepted[0])
        if any(i > excepted[-1] for i in maximums):
            result = max(result, excepted[-1])
        if len(excepted) < 2:
            return result
        for exc_index in range(1, len(excepted)):
            left = excepted[exc_index-1]
            right = excepted[exc_index]
            if any(left < i and i < right for i in maximums):
                result = max(result, right - left - 1)
        return result
arr = [1,2,3,3,2,2]

s = Solution()
print(s.longestSubarray(arr))