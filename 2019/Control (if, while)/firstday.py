#Deony Barrington
#BRRDEO001
#07 March 2019

f_year = eval(input("Enter the first year:\n"))
s_year = eval(input("Enter the second year:\n"))


 
while f_year <= s_year: 
 day = ((1+(5*((f_year-1) % 4)))+(4*((f_year-1) % 100))+(6*((f_year-1)% 400))) % 7
 
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
  
 print("The 1st of January",f_year,"falls on a",dayy)
 
 f_year+= 1
 
 