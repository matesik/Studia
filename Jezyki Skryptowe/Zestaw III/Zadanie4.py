class Odwroc:
    def __init__(self, zdanie) -> None:
        self.zdanie = zdanie
    def Zamien(self):
        return " ".join(self.zdanie.split()[::-1])

o1 = Odwroc("Jestem Groot. Jestem Groot")

print(Odwroc.Zamien(o1))