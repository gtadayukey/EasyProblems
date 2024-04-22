def firstRecurringCharacter(nums1):
    hashset = {}

    for n in nums1:
        if n in hashset:
            return n
        hashset[n] = 1

    return None


if __name__ == "__main__":
    print(firstRecurringCharacter([2, 5, 1, 2, 3, 5, 1, 2, 4]))
    print(firstRecurringCharacter([2, 1, 1, 2, 3]))
    print(firstRecurringCharacter([2, 3, 4, 5]))
