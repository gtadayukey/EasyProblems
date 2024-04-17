def moveZeroes(nums):
    aux = [0] * len(nums)

    j = 0
    k = 0

    for i in range(len(nums)):
        if nums[i] != 0:
            aux[j] = nums[i]
            j += 1
            continue

        aux[-(k + 1)] = 0
        k += 1

    return aux


if __name__ == "__main__":
    print(moveZeroes([0, 1, 0, 3, 12]))
    print(moveZeroes([0]))
    print(moveZeroes([0, 0, 1]))
