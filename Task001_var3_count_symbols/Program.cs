Console.Clear();
Console.Write("Write the text: ");
string text = Console.ReadLine() ?? "0";
text = text.ToLower();
string collection = "";
for(int i = 0; i < text.Length; i++)
{
    if( !collection.Contains(text[i]))
        collection += text[i];
}
string [,] matrix = new string [collection.Length, 2];

for(int i = 0; i < collection.Length; i++)
{
    matrix[i,0] = Convert.ToString(collection[i]);
    matrix[i,1] = "0";
}

for(int i = 0; i < text.Length; i++)
{
    for(int j = 0; j < collection.Length; j++)
        if(text[i] == collection[j])
        {
            matrix[j,1] = Convert.ToString(Convert.ToInt32(matrix[j,1])+1);
        }
}
for(int j = 0; j < collection.Length; j++)
    Console.WriteLine($"Symbol {matrix[j,0]} appears in the text {matrix[j,1]} times.");