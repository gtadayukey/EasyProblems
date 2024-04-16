def merge(nums1, m, nums2, n):
    if n == 0:
        return nums1

    i = j = 0
    temp = []

    while i + j < m + n:
        if nums1[i] > nums2[j]:
            temp.append(nums2[j])
            j += 1
        elif m > i and 2*m - 1 > i + j:
            temp.append(nums1[i])
            i += 1
        else:
            temp.append(nums2[j])
            j += 1

    return temp


if __name__ == "__main__":
    a1 = merge([1, 2, 3, 0, 0, 0], 3, [2, 5, 6], 3)
    print(a1)
