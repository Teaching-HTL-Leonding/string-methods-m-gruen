// Simple program for string methods like contains, indexof, replace, split, substring, trim, tolower, toupper, etc.
// It was very fun to make this program
// I hope you enjoy it

#region Main Program
{
    // I have to use this square bracket thing because we are not allowed to use global variables
    // This will change in the future, but our teacher wants us to use this for now
    // So we can learn how to use methods whit parameters and return values

    string choice;
    char item = ' ';
    char newItem = ' ';
    string text = string.Empty;
    int start = 0;
    int length = 0;

    System.Console.WriteLine("Welcome to the String Methods Program!");
    System.Console.WriteLine("This program will show you how to use string methods like Contains, IndexOf, LastIndexOf, Replace, Substring, Trim, etc.");
    // This was the greeting message
    // It's a good idea to have a greeting message
    // This is because if you look at this program later, you'll know what it does
    // And it also helps you remember what you did
    // So you can great your future self with a greeting message
    // And you can also tell your future self what you did
    // By writing comments like this
    // :D
    // Hi future self! :D
    // I hope you're doing well!
    // I hope you're having a good day!
    // I hope you're having a good life!
    // I hope you're having a good time!
    // What year is it? I hope it's a good year!

    do
    {
        System.Console.WriteLine();
        System.Console.WriteLine("What do you want to do?");
        System.Console.WriteLine("1. Contains");
        System.Console.WriteLine("2. Indexof");
        System.Console.WriteLine("3. Lastindexof");
        System.Console.WriteLine("4. TrimStart");
        System.Console.WriteLine("5. TrimEnd");
        System.Console.WriteLine("6. Trim");
        System.Console.WriteLine("7. Substring");
        System.Console.WriteLine("8. Remove");
        System.Console.WriteLine("9. Replace");
        System.Console.WriteLine("Q. Quit");
        System.Console.Write("Enter your choice: ");
        choice = System.Console.ReadLine()!;
        // The ! is to tell the compiler that the string is not null
        if (choice != "Q")
        {
            System.Console.Write("Enter the text: ");
            text = System.Console.ReadLine()!;
        }
        if (choice is "1" or "2" or "3" or "4" or "5" or "6" or "9")
        {
            System.Console.Write("Enter the item: ");
            item = System.Console.ReadLine()![0];
            if (choice is "9")
            {
                System.Console.Write("Enter the new item: ");
                newItem = System.Console.ReadLine()![0];
            }
        }
        else if (choice is "7" or "8")
        {
            System.Console.Write("Enter the start: ");
            start = int.Parse(System.Console.ReadLine()!);
            System.Console.Write("Enter the length: ");
            length = int.Parse(System.Console.ReadLine()!);
        }

        switch (choice)
        {
            case "1":
                System.Console.Write("The result is: ");
                System.Console.Write(Contains(text, item));
                break;
            case "2":
                System.Console.Write("The result is: ");
                System.Console.Write(IndexOf(text, item));
                break;
            case "3":
                System.Console.Write("The result is: ");
                System.Console.Write(LastIndexOf(text, item));
                break;
            case "4":
                System.Console.Write("The result is: ");
                System.Console.Write(TrimStart(text, item));
                break;
            case "5":
                System.Console.Write("The result is: ");
                System.Console.Write(TrimEnd(text, item));
                break;
            case "6":
                System.Console.Write("The result is: ");
                System.Console.Write(Trim(text, item));
                break;
            case "7":
                System.Console.Write("The result is: ");
                System.Console.Write(Substring(text, start, length));
                break;
            case "8":
                System.Console.Write("The result is: ");
                System.Console.Write(Remove(text, start, length));
                break;
            case "9":
                System.Console.Write("The result is: ");
                System.Console.Write(Replace(text, item, newItem));
                break;
            case "Q":
                System.Console.WriteLine("Goodbye!");
                break;
            default:
                System.Console.WriteLine("Invalid choice!");
                break;
        }
    }
    while (choice != "Q");
}
#endregion

#region String Methods
bool Contains(string text, char item)
{
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == item)
        {
            return true;
        }
    }
    return false;
}
// Troll Method would be to use text.Contains(item);
// But that's cheating
// So I'm just going to show it here for fun:
/*
bool Contains(string text, char item)
{
    return text.Contains(item);
}
*/
// This was just for fun, don't do this in real life

int IndexOf(string text, char item)
{
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == item)
        {
            return i;
        }
    }
    return -1;
}
// Troll Method would be to use text.IndexOf(item);
// For fun, I'm going to show it here:
/*
int IndexOf(string text, char item)
{
    return text.IndexOf(item);
}
*/

int LastIndexOf(string text, char item)
{
    for (int i = text.Length - 1; i >= 0; i--)
    {
        if (text[i] == item)
        {
            return i;
        }
    }
    return -1;
}
// Troll Method would be to use text.LastIndexOf(item);
// For fun, I'm going to show it here:
/*
int LastIndexOf(string text, char item)
{
    return text.LastIndexOf(item);
}
*/

string TrimStart(string text, char item)
{
    int i = 0;
    while (i < text.Length && text[i] == item)
    {
        i++;
    }
    return text.Substring(i);
}
// Troll Method would be to use text.TrimStart(item);
// For fun, I'm going to show it here:
/*
string TrimStart(string text, char item)
{
    return text.TrimStart(item);
}
*/

string TrimEnd(string text, char item)
{
    int i = text.Length - 1;
    while (i >= 0 && text[i] == item)
    {
        i--;
    }
    return text.Substring(0, i + 1);
}
// Troll Method would be to use text.TrimEnd(item);
// For fun, I'm going to show it here:
/*
string TrimEnd(string text, char item)
{
    return text.TrimEnd(item);
}
*/

string Trim(string text, char item)
{
    return TrimStart(TrimEnd(text, item), item);
}
// Troll Method would be to use text.Trim(item);
// For fun, I'm going to show it here:
/*
string Trim(string text, char item)
{
    return text.Trim(item);
}
*/

string Substring(string text, int start, int length)
{
    string result = string.Empty;

    for (int i = start; i < start + length; i++)
    {
        if (i >= text.Length)
        {
            break;
        }
        result += text[i];
    }
    return result;
}
// Troll Method would be to use text.Substring(start, length);
// For fun, I'm going to show it here:
/*
string Substring(string text, int start, int length)
{
    return text.Substring(start, length);
}
*/

string Remove(string text, int start, int length)
{
    string result = string.Empty;

    for (int i = 0; i < text.Length; i++)
    {
        if (i < start || i >= start + length)
        {
            result += text[i];
        }
    }
    return result;
}
// Troll Method would be to use text.Remove(start, length);
// For fun, I'm going to show it here:
/*
string Remove(string text, int start, int length)
{
    return text.Remove(start, length);
}
*/

string Replace(string text, char oldItem, char newItem)
{
    string result = string.Empty;

    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == oldItem)
        {
            result += newItem;
        }
        else
        {
            result += text[i];
        }
    }
    return result;
}
// Troll Method would be to use text.Replace(oldItem, newItem);
// For fun, I'm going to show it here:
/*
string Replace(string text, char oldItem, char newItem)
{
    return text.Replace(oldItem, newItem);
}
*/
#endregion
