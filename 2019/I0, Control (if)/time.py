hours = eval(input("Enter the hours: "))
minutes = eval(input("Enter the minutes: "))
seconds = eval(input("Enter the seconds: "))

if ((hours > 23) or (hours < 0)) or ((minutes > 59) or (minutes < 0)) or ((seconds > 59) or (seconds < 0)):
    print("Your time is invalid.")
else:
    print("Your time is valid.")
