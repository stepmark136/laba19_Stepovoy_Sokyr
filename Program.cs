

Console.Write("Введите строку: ");
string text = Console.ReadLine() ?? "";

System.Console.WriteLine($">>> Анализ строки <<<");
System.Console.WriteLine();
System.Console.WriteLine($"Исходная строка: [{text}]");
System.Console.WriteLine($"Длина: {text.Length}");
System.Console.WriteLine($"Букв: {CountLetters(text)}");
System.Console.WriteLine($"Цифр: {CountDigits(text)}");
System.Console.WriteLine($"Пробелов: {CountCharacter(text, ' ')}");
System.Console.WriteLine($"Слов: {CountWords(text)}");
System.Console.WriteLine($"Без пробелов по краям: [{text.Trim()}]");
System.Console.WriteLine($"Верхний регистр: [{text.ToUpper()}]");
System.Console.WriteLine($"Замена пробелов: [{text.Replace(' ', '_')}]");
Console.Write("Введите один символ для поиска: ");
char target = Convert.ToChar(Console.ReadLine());
int index = FindCharacterIndex(text, target);
if (index == -1)
{
    System.Console.WriteLine("Символ не найден");
}
else
{
    System.Console.WriteLine($"Первый индекс: {index}");
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
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == target)
            return i;
    }
    return -1;
}


int CountWords(string text)
{
    string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    return words.Length;
}

