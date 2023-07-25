#Deony Barrington
#BRRDEO001
#22 March 2019

min_feet = eval(input("Enter the minimum number of feet (not less than 0): \n"))
max_feet = eval(input("Enter the maximum number of feet (not more than 30): \n"))
count = (max_feet-min_feet)+1
print()
print("      |   0\"   1\"   2\"   3\"   4\"   5\"   6\"   7\"   8\"   9\"  10\"  11\" ")

for i in range (count):
    if len(str(min_feet)) == 2:
        print("  ",min_feet,"' | ",sep = '',end = '')
    if len(str(min_feet))== 1:
        print("   ",min_feet,"' | ",sep = "",end = '')
    for j in range (12):
        ft = (min_feet*(1/3.281))
        inch = j*0.025
        ft_inch = ft + inch
        print('{:0.2f}'.format((ft_inch)), end = ' ')
    min_feet+=1
    print()

    