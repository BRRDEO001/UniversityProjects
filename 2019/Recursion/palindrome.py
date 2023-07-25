
def ispalindrome(word):
    sen = word
       
    if len(word)%2 > 0:
        if len(sen) == 1:
                print("Palindrome! ")   
        elif sen[0] != sen[len(sen)-1]:
            print("Not a palindrome! ")
        else:
            return ispalindrome(word[1:(len(word)-1)])
    else:
        if len(sen) == 0:
                print("Palindrome! ")   
        elif sen[0] != sen[len(sen)-1]:
            print("Not a palindrome! ")
        else:
            return ispalindrome(word[1:(len(word)-1)])        

ispalindrome(input("Enter a string: \n"))

    