inp = input("Podaj liczbe z ktorej chcesz silnie: ")
inp = int(inp)
result = 1

for item in range(2, inp + 1):
   result *= item

print(inp, "! = ", result, sep="")