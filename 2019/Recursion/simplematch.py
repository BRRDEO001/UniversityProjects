def match(pattern, word):
    if len(pattern) != len(word):
        print("They don't match. ")
    else:
        if len(word) == 0:
            print("It's a match.")
        elif (pattern[0] == word[0]) or (pattern[0] == "?") :
            return match(pattern[1:len(pattern)-1],word[1:len(word)-1])
        else:
            print("It's a match.")
        


pattern = input("Enter a pattern (or 'q' to quit):\n")
while pattern != "q":
    word = input("Enter a word:\n")
    match(pattern,word)
    pattern = input("Enter a pattern (or 'q' to quit):\n")    