// See https://aka.ms/new-console-template for more information

bool IsValid(string s)
{
    Stack<char> chars = new Stack<char>();

    foreach (char c in s)
    {
        if (c is '(' || c is '[' || c is '{')
        {
            chars.Push(c);
            continue;
        }

        if(chars.Count == 0) return false;

        char pop = chars.Pop();

        if (c is ')' && pop is not '(')
            return false;
        if (c is ']' && pop is not '[')
            return false;

        if (c is '}' && pop is not '{')
            return false;
    }

    return chars.Count == 0;
}

string s = "(]";

Console.WriteLine(IsValid(s));
