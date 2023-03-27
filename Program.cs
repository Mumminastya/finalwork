string[] FillArrayWithRandom(int length)
{
    string[] arr = new string [length];
    Random rnd = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
        var l = rnd.Next(1, 10);
        var rndString = Path.GetRandomFileName();
        if (l < rndString.Length)
        {
            arr[i] = rndString.Substring(0, l);
        }        
    }
    return arr;
}

string[] CutMassive(string[] arr)
{
    int i = 0;
    int l = arr.Length;
    string[] result = new string[arr.Length];
    int j = 0;
    while(i < l)
    {
        if(arr[i].Length <= 3)
        {
            result[j] = arr[i];
            j++;
        }
        i++;
    }

    Console.WriteLine(j);
    Array.Resize(ref result, j);
    return result;
}

void PrintArray(string[] arr)
{
    System.Console.Write($"[{string.Join(",", arr)}]");
}

System.Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
string[] array = FillArrayWithRandom(length);
string[] cutmassive = CutMassive(array);
PrintArray(array);
 Console.Write(" -> ");
PrintArray(cutmassive);