# 2560
class Solution(object):
    floor = [1]

    def generate(self, numRows):
        result = [[1]]
        for i in range(1, numRows):
            self.floor = self.buildNextFloor()
            result.append(self.floor)
        return result

    def buildNextFloor(self):
        new_floor = [self.floor[i]+self.floor[i+1] for i in range(0, len(self.floor)-1)]
        new_floor.insert(0, 1)
        new_floor.append(1)
        return new_floor

s = Solution()
print(s.generate(1))