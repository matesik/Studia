flag = input("Podaj 1 jezeli chcesz szyfrowac, lub 0 jezeli chcesz rozszyfrowac: ")
text = input("Wprowadz tekst bez polskich znakow: ")
length = input("Podaj dlugosc przesuniecia liczbowo: ")
length = int(length) % 26
arr = text.split(" ")
result = ""

def szyfruj(word):
	result = ""
	for item in word:
		if flag == "1":
			if (ord(item) in range(65, 90) and (ord(item) + length > 90)) or (ord(item) in range(97, 122) and (ord(item) + length > 122)):
				result += chr(ord(item) + length - 26)
			else:
				result += chr(ord(item) + length)
		elif flag == "0":
			if (ord(item) in range(65, 90) and (ord(item) - length < 65)) or (ord(item) in range(97, 122) and (ord(item) - length < 97)):
				result += chr(ord(item) - length + 26)
			else:
				result += chr(ord(item) - length)
		else:
			print("Nieodpowiednia flaga!")
			break
	return result

for item in arr:
	result += szyfruj(item) + " "

print("Wynik: ", result)