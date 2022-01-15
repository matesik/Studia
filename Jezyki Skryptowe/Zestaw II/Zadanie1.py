x = int(input("Podaj pierwsza liczbe: "))
y = int(input("Podaj druga liczbe: "))
symbol = input("Podaj rodzaj dzialania: ")


if symbol == "+":
    print("Suma: ", x+y)
elif symbol == "-":
    print("Roznica: ", x-y)
elif symbol == "*":
    print("Iloczyn: ", x*y)
elif symbol == "/":
    if y == 0:
        print("Nie dzielimy przez 0")
    print("Iloraz: ", x/y)
