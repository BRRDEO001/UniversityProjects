#Deony Barrington
#BRRDEO001
#13 May 2019

print("***** Anagram Finder ***** ")
wordlen = eval(input("Enter word length: /n"))
print("Searching... ")
filen = input("Enter file name: \n")
print("Writing results... ")


def checkSimilar(word,line):
    for i in range(len(word)):
        count = 0
        for j in range(len(line)-1):
            if word[i] == line[j]:
                count += 1
        if count == 0:
            return False
    return True


f = open("EnglishWords.txt", "r")
filee = open(filen, "w")
for line in f:
    found = False
    arrmatches = []
    if line == "START\n":
        found = True 
        
    for word in f:
        if (found == True) and ((len(line)-1)==len(word)) and (word != line[:-1]):
            if checkSimilar(word,line) == True:
                arrmatches.append(line[:-1])
                
            display = "['"  
            for j in range(len(arrmatches)):
                if (j+1) == len(arrmatches):
                    display = display + arrmatches[j]+"']"
                else:    
                    display = display + arrmatches[j]+"', " 
            filee.write(display)
filee.close()
f.close()