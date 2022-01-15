import math

class Kolo:
    def __init__(self,r):
        self.r = r  
    def Pole(self):
        return math.pi*(self.r**2)
    def Obwod(self):
        return math.pi*self.r*2

k = Kolo(3)
print("Pole kola wynosi: ", k.Pole())
print("Obwod kola wynosi: ", k.Obwod())