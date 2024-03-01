bool IsAnagram(string s, string t)
{
    if (s.Length != t.Length)
        return false;

    int[] arr = new int[26];

    for (int i = 0; i < s.Length; i++)
    {
        int index = s[i] - 'a';
        arr[index] += 1;
    }

    for (int j = 0; j < t.Length; j++)
    {
        int index = t[j] - 'a';
        arr[index] -= 1;
    }

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] != 0)
            return false;
    }

    return true;
}