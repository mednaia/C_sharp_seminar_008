// Составить частотный словарь элементов двумерного массива
//Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

int CountCharsInString(string text, char symbol)
{
    int count = 0;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == symbol)
        {
            count++;
        }

    }
    return count;
}
string UniqueCharsInString(string text)
{
    string newText = string.Empty;
    for (int i = 0; i < text.Length; i++)
    {
        bool check = false;
        for (int j = i + 1; j < text.Length; j++)
        {
            if (text[i] == text[j]) check = true;
        }
        if (!check) newText = newText + $"{text[i]}";
    }
    return newText;
}
Console.Clear();
Console.WriteLine("Write the text:");
string text = Console.ReadLine() ?? " ";
double size = text.Length;
double percent = 0;
string newText = UniqueCharsInString(text);
for (int i = 0; i < newText.Length; i++)
{
    int count = CountCharsInString(text, newText[i]);
    percent = count / size * 100;
    Console.WriteLine($"Symbol {newText[i]} is in the text {count} times. Percent = {Math.Round(percent, 2)} %");
}