// bool IsAnagram(string s, string t)
// {
//     if (s.Length != t.Length)
//         return false;

//      if(s == t) return true;


//     int[] arr = new int[26];

//     for (int i = 0; i < s.Length; i++)
//     {
//         int index = s[i] - 'a';
//         arr[index] += 1;
//     }

//     for (int j = 0; j < t.Length; j++)
//     {
//         int index = t[j] - 'a';
//         arr[index] -= 1;
//     }

//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] != 0)
//             return false;
//     }

//     return true;
// }

bool IsAnagram(string s, string t)
{
    if (s.Length != t.Length)
        return false;

    if (s == t)
        return true;
    Dictionary<char, int> charCounter = new();

    for (int i = 0; i < s.Length; i++)
    {
        if (!charCounter.ContainsKey(s[i]))
            charCounter[s[i]] = 0;
        if (!charCounter.ContainsKey(t[i]))
            charCounter[t[i]] = 0;

        charCounter[s[i]] += 1;
        charCounter[t[i]] -= 1;
    }

    foreach (var (key, value) in charCounter)
    {
        if (value != 0)
            return false;
    }
    return true;
}
