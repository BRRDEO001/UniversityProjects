#BRRDEO001
#DEONY BARRINGTON
#12 APRIL 2019

def main():
    import random
    
    arrResponses = ['Have you tried it on a different operating system?','Did you reboot it?','What colour is it?','You should consider installing anti-virus software.','Contact Telkom.','I should get that looked at if I were you.']
    
    print("Welcome to the automated technical support system.")
    problem = input("Please describe your problem:\n")
    
    
    while problem != "quit":
        ResPos = random.randint(0,5)
        print(arrResponses[ResPos]) 
        problem = input("")


if __name__=='__main__':
    main()


    
