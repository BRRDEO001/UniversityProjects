#Deony Barrington
#BRRDEO001
#09 March 2019


import math

ans = 2*2/math.sqrt(2)


cnt = 0
x = 0

while x!=2:
 cnt += 1
 x = math.sqrt(2)
 for i in range(cnt):
   y  = math.sqrt(2+x)
   x = y
 ans = ans*2/x
ansStr = "Approximation of pi: "+ str(round(ans, 3))
print(ansStr)
r = eval(input("Enter the radius:\n"))
area = ans*r*r
stringg = "Area: "+ str(round(area, 3))
print(stringg)