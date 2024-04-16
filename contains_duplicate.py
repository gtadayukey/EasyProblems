def containsDuplicate(nums):
    hashset = set()

    for num in nums:
        if num in hashset:
            return True
        else:
            hashset.add(num)

    return False


if __name__ == "__main__":
    print(containsDuplicate([1, 2, 3, 1]))
    print(containsDuplicate([1, 2, 3, 4]))
    print(containsDuplicate([1, 1, 1, 3, 3, 4, 3, 2, 4, 2]))
