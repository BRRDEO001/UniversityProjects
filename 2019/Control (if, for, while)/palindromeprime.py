#DEONY BARRINGTON
#BRRDEO001
#15/03/2019

import math

n = eval(input("Enter the start point N:\n"))
m = eval(input("Enter the end point M:\n"))
print("The palindromic primes are:")

for i in range(n+1,m):
    check = False
    for j in range(2,int(math.sqrt(i)+1)):
        if i%j == 0:
            check=True
    if check == False:
        num=str(i)
        r=""
        for k in range(len(num)-1,-1,-1):
            r = r+num[k]
        if r == num:
            print(i)