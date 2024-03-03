// See https://aka.ms/new-console-template for more information
bool IsPalindrome(string s)
{
    int leftIndex = 0;
    int rightIndex = s.Length - 1;

    while (leftIndex < rightIndex)
    {
        if (!char.IsLetterOrDigit(s[leftIndex]))
        {
            leftIndex++;
        }
        else if (!char.IsLetterOrDigit(s[rightIndex]))
        {
            rightIndex--;
        }
        else if (char.ToLower(s[leftIndex]) == char.ToLower(s[rightIndex]))
        {
            leftIndex++;
            rightIndex--;
        }
        else
        {
            return false;
        }
    }

    return true;
}
Console.WriteLine("Hello, World!");
