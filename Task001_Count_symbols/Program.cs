// Из текста взять каждый символ и посчитать сколько раз он встречается и его % встречаемости
Console.Write("Write the text: ");
string text = Console.ReadLine() ?? "0";
for (int i = 0; i < text.Length; i++)
{
    char symbol = text[i];
    int count = 1;
    for (int j = i+1; j < text.Length; j++)
    {
        if (symbol==text[j])
        {
            count++; 
            text = text.Remove(j,1); 
            j--;
        }
    }
    Console.WriteLine($"Symbol {symbol} appears in the text {count} times.");
}
