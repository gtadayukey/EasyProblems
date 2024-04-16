def twoSum(nums, target):
    hashset = set()
    i = 0

    while len(nums) > i:
        complement = target - nums[i]
        if nums[i] in hashset:
            return i, nums.index(complement)
        else:
            hashset.add(complement)

        i += 1


if __name__ == "__main__":
    print(twoSum([2, 7, 11, 15], 9))
    print(twoSum([3, 2, 4], 6))
    print(twoSum([3, 3], 6))
