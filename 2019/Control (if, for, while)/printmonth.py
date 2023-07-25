#DEONY BARRINGTON
#BRRDEO001
#15/03/2019

month  = input("Enter the month ('January', ..., 'December'): ")
day = input("Enter the start day ('Monday', ..., 'Sunday'): ")

print(month)
print("Mo Tu We Th Fr Sa Su")

count=0
if day == 'Monday':
    num=1
elif day == 'Tuesday':
    num=0
elif day == 'Wednesday':
    num=-1
elif day == 'Thursday':
    num=-2
elif day == 'Friday':
    num=-3
elif day == 'Saturday':
    num=-4
elif day == 'Sunday':
    num=-5

if month=='February':
    for i in range(6):
        for j in range(7):
            if (num>=1) and (num<29):
                if j!=6:
                    print("{0:>2}".format(num), end=" ")
                    num+=1
                else:
                    print("{0:>2}".format(num))
                    num+=1
            else:
                if j!=6:
                    print("{0:>2}".format(" "), end=" ")
                    num+=1
                else:
                    print("{0:>2}".format(" "))
                    num+=1                       
elif (month=='January') or (month=='March') or (month=='May') or (month=='July') or (month=='August') or (month=='October') or (month=='December'):
    for i in range(6):
        for j in range(7):
            if (num>=1) and (num<32):
                if j!=6:
                    print("{0:>2}".format(num), end=" ")
                    num+=1
                else:
                    print("{0:>2}".format(num))
                    num+=1
            else:
                if j!=6:
                    print("{0:>2}".format(" "), end=" ")
                    num+=1
                else:
                    print("{0:>2}".format(" "))
                    num+=1                        
else:
    for i in range(6):
        for j in range(7):
            if (num>=1) and (num<31):
                if j!=6:
                    print("{0:>2}".format(num), end=" ")
                    num+=1
                else:
                    print("{0:>2}".format(num))
                    num+=1
            else:
                if j!=6:
                    print("{0:>2}".format(" "), end=" ")
                    num+=1
                else:
                    print("{0:>2}".format(" "))
                    num+=1     