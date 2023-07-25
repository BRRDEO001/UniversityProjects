#DEONY BARRINGTON
#BRRDEO001
#15/03/2019


num=eval(input("Enter the start number: "))

if (num>-6) and (num<93):
    for i in range(num, num+6):
        print("{0:>2}".format(i), end=" ")
    print("{0:>2}".format(num+6)) 