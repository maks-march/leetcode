import random

with open('numbers.txt', 'w') as f:
    n = 100000
    while n > 20:
        count = random.randint(1, 20)
        num = random.randint(0, 2**63-1)
        for _ in range(count):
            f.write(f"{num}\n")
        n -= count
    num = random.randint(0, 2**63-1)
    for _ in range(n):
        f.write(f"{num}\n")
