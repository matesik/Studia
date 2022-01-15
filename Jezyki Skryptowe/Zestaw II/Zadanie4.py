inp= input("Wprowadz slowo do przetestowania: ")
inp = inp.lower()
counter = 0

for item in range(1, len(inp) + 1):
	if inp[item - 1] == inp[-item]:
		inp += 1
	else:
		break

if len(inp) == counter:
	print("Podane slowo jest palindromem")
else:
	print("Podane słowo nie jest palindromem")