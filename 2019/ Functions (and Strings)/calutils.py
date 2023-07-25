#Deony Barrington
#BRRDEO001
#31 March 2019

def is_leap_year(year):
    
    
    if (year%4==0) and ((year%100!=0) or (year%400==0)):
        return True
    else:
        return False
    
def month_name(number):
    
    if number == 1:
        return "January"
    elif number == 2:
        return "February"
    elif number == 3:
        return "March"
    elif number == 4:
        return "April"
    elif number == 5:
        return "May"
    elif number == 6:
        return "June"
    elif number == 7:
        return "July"
    elif number == 8:
        return "August"
    elif number == 9:
        return "September"
    elif number == 10:
        return "October"
    elif number == 11:
        return "November"
    elif number == 12:
        return "December"
    
def days_in_month(month,number,year):
    
    if ((year%4==0) and ((year%100!=0) or (year%400==0))) and (month_name(month)== February):
        number = 29
    else:
        number = 28
    
    if month_name(month) == "January":
        day = 31
    elif month_name(month) == "March":
        day = 31
    elif month_name(month) == "April":
        day = 30
    elif month_name(month) == "May":
        day = 31
    elif month_name(month) == "June":
        day = 30
    elif month_name(month) == "July":
        day = 31
    elif month_name(month) == "August":
        day = 31
    elif month_name(month) == "September":
        day = 30
    elif month_name(month) == "October":
        day = 31
    elif month_name(month) == "November":
        day = 30
    elif month_name(month) == "December":
        day = 31

def first_day_of_year(year):
    day = ((1+(5*((year-1) % 4)))+(4*((year-1) % 100))+(6*((year-1)% 400))) % 7
    return day

def first_day_of_month(month_number, year):
    day = (((1 + (5*((year-1) % 4))) + (4*((year-1) % 100)) + (6*((year-1)% 400))) % 7)
    
    if day == 0:
        dayy = "Sunday."
    elif day == 1:
        dayy = "Monday."
    elif day == 2:
        dayy = "Tuesday."
    elif day == 3:
        dayy = "Wednesday."
    elif day == 4:
        dayy = "Thursday."
    elif day == 5:
        dayy = "Friday."
    elif day == 6:
        dayy = "Saturday."     
    return day