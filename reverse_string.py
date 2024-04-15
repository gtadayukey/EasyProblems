def reverseString(s):
    i = 0

    while len(s) / 2 > i:
        temp = s[i]
        s[i] = s[(i + 1) * -1]
        s[(i + 1) * -1] = temp
        i += 1

    return s


if __name__ == "__main__":
    s1 = ['H', 'e', 'l', 'l', 'o', ' ', 'e', 'v', 'e', 'r', 'y', 'o', 'n', 'e', '!']
    reverseString(s1)
    print(s1)
