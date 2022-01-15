inp = input("Podaj liczbe: ")
inp = int(inp)

def silnia(num):
   if num > 1:
       return num*silnia(num-1)
   return 1

print(inp, "! = ", silnia(inp), sep="")