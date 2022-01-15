def preprocess_strong_suffix(shift, border_position, pattern, m):
    i = m
    j = m + 1
    border_position[i] = j

    while i > 0:
        while j <= m and pattern[i - 1] != pattern[j - 1]:
            if shift[j] == 0:
                shift[j] = j - i

            j = border_position[j]

        i -= 1
        j -= 1
        border_position[i] = j

def preprocess_alternative_case(shift, border_position, _, m):
    j = border_position[0]
    for i in range(m + 1):
        if shift[i] == 0:
            shift[i] = j

        if i == j:
            j = border_position[j]

def boyer_moore(text, pattern):
    [s, m, n] = [0, len(pattern), len(text)]

    border_position = [0] * (m + 1)
    shift = [0] * (m + 1)

    preprocess_strong_suffix(shift, border_position, pattern, m)
    preprocess_alternative_case(shift, border_position, pattern, m)

    while s <= n - m:
        j = m - 1

        while j >= 0 and pattern[j] == text[s + j]:
            j -= 1

        if j < 0:
            print("Indeks wzorca = %d" % s)
            s += shift[0]
        else:
            s += shift[j + 1]

text = input("Podaj tekst: ")
pattern = input("Podaj wzorzec: ")
text = text.lower()
pattern = pattern.lower()
boyer_moore(text, pattern)
