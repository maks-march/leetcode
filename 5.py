# 2106
class Solution(object):
    maximumHarvested = []

    def getMaximumHook(self, steps, paths):
        paths.reverse()
        for weight, needed_steps, available_steps in paths:
            if needed_steps <= steps:
                return weight
        return 0

    def maxTotalFruits(self, fruits, startPos, k):
        started_summary = 0
        right = 0
        while right < len(fruits) - 1 and fruits[right][0] < startPos:
            right += 1
        if fruits[right][0] == startPos:
            started_summary += fruits[right][1]
            left = right - 1
            right += 1
        else:
            left = right - 1
        i = right
        right_paths = []
        summary = 0
        while i < len(fruits):
            length = fruits[i][0] - startPos
            summary += fruits[i][1]
            steps = fruits[i][0] - startPos
            if steps > k or steps < 0:
                break
            right_paths.append([summary, steps * 2, k - length])
            i += 1
        left_paths = []
        i = left
        summary = 0
        while i >= 0:
            length = startPos - fruits[i][0]
            summary += fruits[i][1]
            steps = startPos - fruits[i][0]
            if steps > k:
                break
            left_paths.append([summary, steps * 2, k - length])
            i -= 1
        print(right_paths)
        print(left_paths)
        weights = [0]
        for weight, needed_steps, available_steps in right_paths:
            added_weight = self.getMaximumHook(available_steps, left_paths)
            weights.append(weight+added_weight)
        for weight, needed_steps, available_steps in left_paths:
            added_weight = self.getMaximumHook(available_steps, right_paths)
            weights.append(weight+added_weight)
        return max(weights) + started_summary
# fruits = [[0,9],[4,1],[5,7],[6,2],[7,4],[10,9]]
fruits = [[0, 10000]]
startPos = 200000
k = 0
s = Solution()
print(s.maxTotalFruits(fruits, startPos, k))