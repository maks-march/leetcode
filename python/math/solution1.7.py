class Solution7:
    enterprises = 6
    capitals = [0, 40, 80, 120, 160, 200]
    initial_capital = 200

    table1 = {0: 0, 40: 8, 80: 10, 120: 11, 160: 12, 200: 18}
    table2 = {0: 0, 40: 6, 80: 9, 120: 11, 160: 13, 200: 15}
    table3 = {0: 0, 40: 3, 80: 4, 120: 7, 160: 11, 200: 18}
    table4 = {0: 0, 40: 4, 80: 6, 120: 8, 160: 13, 200: 16}
    table5 = {0: 0, 40: 7, 80: 8, 120: 11, 160: 11, 200: 11}
    table6 = {0: 0, 40: 5, 80: 9, 120: 12, 160: 13, 200: 13}
    tables = [
        table1, table2, table3, table4, table5, table6
    ]
    
    def common_stonks(self, table, x):
        return self.tables[table-1].get(x, 0)

    def get_key_by_value(self, dictionary, target_value):
        for key, value in dictionary.items():
            if value == target_value:
                return key
        return None

    def solve(self):
        self.Z = {}
        self.Xz = {}
        self.Prevs = {}

        di = {0: 0}
        diX = {0: 0}
        diPrevs = {0: 0}
        for cap in self.capitals:
            di[cap] = self.common_stonks(self.enterprises, cap)
            diX[cap] = cap
            diPrevs[cap] = 0
        self.Z[self.enterprises] = di
        self.Xz[self.enterprises] = diX
        self.Prevs[self.enterprises] = diPrevs

        for k in range(self.enterprises-1, 0, -1):
            newZ = {0: 0}
            newX = {0: 0}
            newPrev = {0: 0}
            prevZ = self.Z[k+1]
            for prev_cap in self.capitals[1:]:
                max_stonks = 0
                max_cost = 0
                max_prev = 0
                for x in range(0, prev_cap+1, 40):
                    cap = prev_cap - x
                    curr_stonks = self.common_stonks(k, x)
                    curr_prev = prevZ[cap]
                    current = curr_prev + curr_stonks
                    if (current > max_stonks):
                        max_stonks = current
                        max_cost = x
                        max_prev = curr_prev
                newZ[prev_cap] = max_stonks
                newX[prev_cap] = max_cost
                newPrev[prev_cap] = max_prev
            self.Z[k] = newZ
            self.Xz[k] = newX
            self.Prevs[k] = newPrev

    def full_print(self):
        for (ep_key, ep_value) in self.Z.items():
            print(ep_key)
            for (key, value) in ep_value.items():
                print(key, value, self.Xz[ep_key][key], self.Prevs[ep_key][key])

    def printResult(self):
        result = max(self.Z[1].values())
        print(f"Итог: {result}")
        x = result
        for k in range(1, 7):
            key = self.get_key_by_value(self.Z[k], x)
            prev = self.Prevs[k][key]
            cost = self.Xz[k][key]
            print(f"{k}-ое предприятие заработало {x-prev} при вложении {cost} млн.")
            x = prev

def main():
    s = Solution7()
    s.solve()
    s.printResult()

main()