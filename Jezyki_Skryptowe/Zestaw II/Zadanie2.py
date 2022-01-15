wejscie = input("Podaj liczby (oddziel je spacja): ")
arr = wejscie.split(" ")
arr.sort()
arrint = list(map(int, arr))
suma = 0
med = 0

for item in arrint:
	suma += item


if len(arrint) % 2 == 0:
	srodek = int(len(arrint) / 2)
	med = (arrint[srodek] + arrint[srodek - 1]) / 2
else:
	med = arrint[int((len(arrint) - 1) / 2)]


print("Suma: ", suma)
print("Wartosc srednia: ", suma/len(arrint))
print("Mediana :", med)