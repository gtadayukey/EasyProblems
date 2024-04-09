int[] nums = [2, 7, 11, 15];
int[] twoSum = TwoSum(nums, 9);

foreach (int num in twoSum)
{
    Console.WriteLine(num); // [0,1]
}

Console.WriteLine();

nums = [3, 2, 4];
twoSum = TwoSum(nums, 6);

foreach (int num in twoSum)
{
    Console.WriteLine(num); // [1,2]
}

Console.WriteLine();

nums = [3, 3];
twoSum = TwoSum(nums, 6);

foreach (int num in twoSum)
{
    Console.WriteLine(num); // [0,1]
}


static int[] TwoSum(int[] nums, int target)
{
    int[] output = new int[2];

    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] + nums[j] == target)
            {
                output[0] = i;
                output[1] = j;
                return output;
            }
        }
    }

    return output;
}

