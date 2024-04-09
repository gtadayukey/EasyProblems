int[] mergedArray = MergeSortedArrays([0, 3, 4, 31], [4, 6, 30]);

foreach (int num in mergedArray)
{
    Console.WriteLine(num + " ");
}

static int[] MergeSortedArrays(int[] array1, int[] array2)
{
    if(array1.Length == 0)
    {
        return array2;
    }

    if(array2.Length == 0)
    {
        return array1;
    }

    int[] mergedArray = new int[array1.Length + array2.Length];

    int i = 0, j = 0, count = 0;

    while (count < mergedArray.Length)
    {

        if (array1.Length == i || (array2.Length > j && array1[i] > array2[j]))
        {
            mergedArray[count] = array2[j];
            j++;
        }
        else
        {
            mergedArray[count] = array1[i];
            i++;
        }

        count++;
    }

    return mergedArray;
}

// Time Complexity: O(n)
// Space Complexity: O(1)