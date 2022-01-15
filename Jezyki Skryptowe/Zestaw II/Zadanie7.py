file = open("text.txt", "r")
inp = file.read()
arr = inp.split(" ")
spaces = len(arr) - 1
file.close()

file = open("result.txt", "w")
file.write(str(spaces))
file.close()
