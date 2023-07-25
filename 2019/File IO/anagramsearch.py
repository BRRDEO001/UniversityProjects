def checkSimilar(word,line):
    for i in range(len(word)):
        count = 0
        for j in range(len(line)-1):
            if word[i] == line[j]:
                count += 1
        if count == 0:
            return False
        
    return True

print("***** Anagram Finder ***** ")

import os.path
if os.path.isfile("EnglishWords.txt"): 
    word= input("Enter a word:\n")
    if word == "NULL":
        print("***** Anagram Finder ***** ")
        print("Sorry, could not find file 'EnglishWords.txt'. ")
        print("")
    words = 0
    
    f = open("EnglishWords.txt","r")
    found = False
    arrmatches = []
    for line in f:
        if line == "START\n":
            found = True
        if (found == True) and ((len(line)-1)==len(word)) and (word != line[:-1]):
            if checkSimilar(word,line) == True:
                arrmatches.append(line[:-1])
    
    if len(arrmatches) > 0:
        for i in range(len(arrmatches)):
            for j in range(i, (len(arrmatches))):
                if arrmatches[i] > arrmatches[j]:
                    temp = arrmatches[i]
                    arrmatches[i] = arrmatches[j]
                    arrmatches[j] = temp
        
        display = "['"  
        for j in range(len(arrmatches)):
            if (j+1) == len(arrmatches):
                display = display + arrmatches[j]+"']"
            else:    
                display = display + arrmatches[j]+"', "
        print(display)         
    else:
        print("Sorry, anagrams of '"+word+"' could not be found. ")
    
      
    f.close()
else:
    print("Sorry, could not find file 'EnglishWords.txt'. ")