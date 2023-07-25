
import math

VectorA = input("Enter vector A:\n")
VectorB = input("Enter vector B:\n")

arrVectA = VectorA.split()
arrVectB = VectorB.split()

ApB = "A+B = ["
dot = 0
normA = 0
normB = 0
for i in range (3):
    val = (eval(arrVectA[i])+eval(arrVectB[i]))
    if i == 2:
        ApB = ApB + str(val) + "]"
    else:
        ApB = ApB + str(val) + ", "
        
    dot = dot + (eval(arrVectA[i])*eval(arrVectB[i]))   
    normA = normA + (eval(arrVectA[i]))*(eval(arrVectA[i]))
    normB = normB + (eval(arrVectB[i]))*(eval(arrVectB[i]))
    
print(ApB)
print("A.B = "+ str(dot))
print("|A| = "+'{:0.2f}'.format(math.sqrt(normA)))
print("|B| = "+'{:0.2f}'.format(math.sqrt(normB)))
