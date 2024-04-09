int[] array = [0, 1, 0, 3, 12];

MoveZeroes(array);

foreach (int i in array)
{
    Console.Write(i + " ");
}

static void MoveZeroes(int[] nums)
{
    int[] aux = new int[nums.Length];

    int j = 0;
    int k = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] != 0)
        {
            aux[j] = nums[i];
            j++;
            continue;
        }

        aux[^(k + 1)] = 0;
        k++;
    }

    aux.CopyTo(nums, 0);
}