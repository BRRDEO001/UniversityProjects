#Deony Barrington
#BRRDEO001
#01/03/2019

import math

a = eval(input("Enter the length of the first side: "))
b = eval(input("Enter the length of the second side: "))
c = eval(input("Enter the length of the third side: "))        
s = ((a+b+c)/2)
s = (math.sqrt(s*(s-a)*(s-b)*(s-c)))

print("The area of the triangle with sides of length ",a," and ",b," and ",c," is ",s,".", sep = "")