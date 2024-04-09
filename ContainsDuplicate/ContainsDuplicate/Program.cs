
Console.WriteLine(ContainsDuplicate([1, 2, 3, 1]));

Console.WriteLine(ContainsDuplicate([1, 2, 3, 4]));

Console.WriteLine(ContainsDuplicate([1, 1, 1, 3, 3, 4, 3, 2, 4, 2]));

static bool ContainsDuplicate(int[] nums)
{
    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] == nums[j])
            {
                return true;
            }
        }
    }

    return false;
}
