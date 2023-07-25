#Deony Barrington
#BRRDEO001
#22 March 2019 

monthN = (input("Enter the month: "))
month= monthN.upper()
year = eval(input("Enter the year: "))


if ((year%4) == 0) and ((year%400) == 0):
 if month == "JANUARY":
  t = 0
 elif month == "FEBRUARY":
  t = 3
 elif month == "MARCH":
  t = 3
 elif month == "APRIL":
  t = 6
 elif month == "MAY":
  t = 1
 elif month == "JUNE":
   t = 4
 elif month == "JULY":
  t = 6
 elif month == "AUGUST":
  t = 2
 elif month == "SEPTEMBER":
  t = 5
 elif month == "OCTOBER":
  t = 0
 elif month == "NOVEMBER":
  t = 3
 elif month == "DECEMBER":
  t = 5 
else:
  if month == "JANUARY":
   t = 0
  elif month == "FEBRUARY":
   t = 3
  elif month == "MARCH":
    t = 4
  elif month == "APRIL":
   t = 0
  elif month == "MAY":
   t = 2
  elif month == "JUNE":
   t = 5
  elif month == "JULY":
   t = 0
  elif month == "AUGUST":
   t = 3
  elif month == "SEPTEMBER":
   t = 6
  elif month == "OCTOBER":
   t = 1
  elif month == "NOVEMBER":
   t = 4
  elif month == "DECEMBER":
   t = 6
print(t) 
print(month)
day = ((1 + t + (5*((year-1) % 4))) + (4*((year-1) % 100)) + (6*((year-1)% 400))) % 7


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
  
print("The 1st of",monthN,year,"is a",dayy )
