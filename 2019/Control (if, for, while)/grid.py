#DEONY BARRINGTON
#BRRDEO001
#15/03/2019

num=eval(input("Enter the start number: "))
count=0

if (num>-6) and (num<2):
    for i in range(6):
        for j in range(7):
            if j!= 6:
                print("{0:>2}".format(num+count), end=" ")
                count+=1
            else:
                print("{0:>2}".format(num+count))
                count+=1