class Zespolona: 
    def __init__(self, x, y) -> None:
        self.x = x
        self.y = y
    def __dodaj__(self, other)->object:
        return Zespolona(self.x + other.x, self.y + other.y)
    def __odejmij_(self, other)->object:
        return Zespolona(self.x - other.x, self.y - other.y)
    def __repr__(self) -> str:
         return f'Zespolona({self.x}, {self.i})'

z1 = Zespolona(2,3)
z2 = Zespolona(3,5)

print(z1+z2)
print(z1-z2)