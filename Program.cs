string text = "Код 2026";


Console.WriteLine(text.Length);
Console.WriteLine(text[0]);
Console.WriteLine(text[text.Length - 1]);
Console.WriteLine();
Console.WriteLine(CountCharacter("мама", 'м'));
Console.WriteLine(CountCharacter("Код 2026", ' '));
Console.WriteLine(CountCharacter("", 'а'));
Console.WriteLine(CountDigits("Код 2026!"));
Console.WriteLine(CountLetters("Код 2026!"));
Console.WriteLine(CountDigits("A2B3"));
Console.WriteLine(FindCharacterIndex("banana", 'a'));
Console.WriteLine(FindCharacterIndex("banana", 'b'));
Console.WriteLine(FindCharacterIndex("banana", 'z'));
Console.WriteLine(FindCharacterIndex("", 'a'));
if (text.Length > 0)
{
    Console.WriteLine($"Первый символ: {text[0]}");
}





int CountCharacter(string text, char target)
{
    int count = 0;

    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == target)
        {
            count++;
        }
    }

    return count;
}




int CountLetters(string text)
{
    int count = 0;

    foreach (char symbol in text)
    {
        if (char.IsLetter(symbol))
        {
            count++;
        }
    }

    return count;
}


int CountDigits(string text)
{
    int count = 0;

    foreach (char symbol in text)
    {
        if (char.IsDigit(symbol))
        {
            count++;
        }
    }

    return count;
}



int FindCharacterIndex(string text, char target)
{
    int index = -1;

    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == target)
        {
            index = i;
            return index;
        }
    }

    return index;
}