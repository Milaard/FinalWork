string[]array = GetArray();
//string[] array = new[] {"Hello", "2", "world", ":-"};
string[] output = FilterArray(array, 3);

Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", output)}]");
Console.ReadKey();

string[] GetArray()
{
    Console.Write("Введите значения через пробел: ");
    return Console.ReadLine().Split(" ");
}

int CountLessThan(string[] input, int n)
{
    int count = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if(input[i].Length <= n)
        {
            count++;
        }
    }
    return count;
}
string[] FilterArray(string[] input, int n)
{
    int count = CountLessThan(input, n);
    string[] output = new string[count];
    int j = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= n)
        {
        
            output[j] = input[i];
            j++;
        }
    }
    return output;
}