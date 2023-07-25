#BRRDEO001
#DEONY BARRINGTON
#12 APRIL 2019

def main():
    D = {'crashed':'Are the drivers up to date?', 'blue':'Ah, the blue screen of death. And then what happened?', 'hacked':'You should consider installing anti-virus software.', 'bluetooth':'Have you tried mouthwash?', 'windows':'Ah, I think I see your problem. What version?', 'apple':'You do mean the computer kind?', 'spam':'You should see if your mail client can filter messages.', 'connection':'Contact Telkom.'}
    
    print("Welcome to the automated technical support system.")
    problem = input("Please describe your problem:\n")
    
    
    while problem != "quit":
        
        if (problem in D) == False:
            print("Curious, tell me more.")
            problem = input("")    
        else:
            print(D[problem]) 
            problem = input("")
            
if __name__=='__main__':
    main()        
        
        


