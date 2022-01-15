d = 256

def search(text, pattern, q):
    pattern_len = len(pattern)
    text_len = len(text)
    [j, p, t, h] = [0, 0, 0, 1]

    for i in range(pattern_len-1):
        h = (h * d) % q

    for i in range(pattern_len):
        p = (d * p + ord(pattern[i])) % q
        t = (d * t + ord(text[i])) % q

    for i in range(text_len-pattern_len + 1):
        if p == t:
            for j in range(pattern_len):
                if text[i + j] != pattern[j]:
                    break

            j += 1
            if j == pattern_len:
                print("Indeks wzorca = %d" % i)

        if i < text_len-pattern_len:
            t = (d*(t-ord(text[i])*h) + ord(text[i + pattern_len])) % q

            if t < 0:
                t = t + q

q = 101
text = input("Podaj tekst: ").lower()
pattern = input("Podaj wzorzec: ").lower()
search(text, pattern, q)
