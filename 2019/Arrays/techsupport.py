#BRRDEO001
#DEONY BARRINGTON
#12 APRIL 2019

def main():
    D = {'crashed':'Are the drivers up to date?', 'blue':'Ah, the blue screen of death. And then what happened?', 'hacked':'You should consider installing anti-virus software.', 'bluetooth':'Have you tried mouthwash?', 'windows':'Ah, I think I see your problem. What version?', 'apple':'You do mean the computer kind?', 'spam':'You should see if your mail client can filter messages.', 'connection':'Contact Telkom.'}
    
    print("Welcome to the automated technical support system.")
    problem = input("Please describe your problem:\n")
    arrProblem = problem.split()
    found = False
    while problem != "quit":
        
        for word in arrProblem:
            if (word in D) == True: 
                found = True
                break
        if found == False:
            print("Curious, tell me more.")
            problem = input("")
            arrProblem = problem.split()
        else:
            print(D[word])
            problem = input("")
            arrProblem = problem.split()
        found = False
if __name__=='__main__':
    main()     