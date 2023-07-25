#Deony Barrington
#BRRDEO001
#22 March 2019

min_feet = eval(input("Enter the minimum number of feet (not less than 0): \n"))
max_feet = eval(input("Enter the maximum number of feet (not more than 99): \n"))
count = max_feet - min_feet

if (min_feet>=0) and (max_feet<=100):
    for i in range(count+1):
        metres = round((min_feet/3.281),2)
        if len(str(min_feet)) == 1:
            print("   ",min_feet,"' |   ", '{:0.2f}'.format((metres)),"m", sep = '')
        else: 
            print("  ",min_feet,"' |   ", '{:0.2f}'.format((metres)),"m", sep = '')
        min_feet += 1