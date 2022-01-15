import math

class Punkt:
    def __init__(self,x,y) -> None:
        self.x = x
        self.y = y
    def Odleglosc(self, other):
        return math.sqrt((self.x-other.x)**2+(self.y-other.y)**2)

p1 = Punkt(2,2)
p2 = Punkt(1,1)

print("Odleglosc miedzy punktami wynosi: ", Punkt.Odleglosc(p1,p2))