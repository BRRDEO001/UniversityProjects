#Deony Barrington
#BRRDEO001
#22 March 2019

min_inch = eval(input("Enter the minimum number of inches (not less than 0): \n"))
max_inch = eval(input("Enter the maximum number of inches (not greater than 11): \n"))
count = (max_inch - min_inch)+1
inch = min_inch

if (min_inch>=0) and (max_inch<12):
   
   print("Inches: ", end = '')
   for i in range(count):
      metres = round((inch*0.0254),2)
      
      if len(str('{:0.2f}'.format((metres)))) > len(str(inch)):
         for j in range (len(str('{:0.2f}'.format((metres))))-len(str(inch))):
            print(" ", end = '')
           
      print(inch, end = ' ')
      inch += 1
      
   print()
   print("Metres:",end = ' ')
   
   for i in range(count):
      metres = round((min_inch*0.0254),2)
      print('{:0.2f}'.format((metres)), end = ' ')
      min_inch += 1