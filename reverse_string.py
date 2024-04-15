def reverseString(self, s):
    i = 0

    while len(s) / 2 > i:
        temp = s[i]
        s[i] = s[(i + 1) * -1]
        s[(i + 1) * -1] = temp
        i += 1
