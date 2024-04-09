
string s = ReverseString("Hi my name is Tadayuki");

Console.WriteLine(s);

static string ReverseString(string value)
{
    if(string.IsNullOrWhiteSpace(value) || value.Length < 2)
    {
        return "Not good";
    }

    char[] array = value.ToCharArray();
    char temp;

    for (int i = 0; i < array.Length / 2; i++)
    {
        temp = array[i];
        array[i] = array[^(i + 1)];
        array[^(i + 1)] = temp;
    }

    return new string(array);
}

// Time Complexity: O(n/2) or O(n) 
// Space Complexity: O(1) 



