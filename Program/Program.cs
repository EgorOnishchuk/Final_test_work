string[] CreateArray(int length)
{
    string[] array = new string[length];

    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива.");
        array[i] = Console.ReadLine();
    }
    
    return array;
}

void PrintArrayElements(string[] array, string version)
{   
    Console.Write($"Элементы массива {version} - ");

    int length = array.Length;

    for (int i = 0; i < length; i++)
    {
        if (array[i].Length != 0)
        {
            Console.Write($"{array[i]} ");
        }
    }

    Console.WriteLine();
}

void ChangeArray(string[] array, int symbols = 3)
{   
    int length = array.Length;

    for (int i = 0; i < length; i++)
    {
        if (array[i].Length > symbols)
        {
            array[i] = string.Empty;   
        }
    }
}


Console.WriteLine("Введите количество элементов массива.");
int length = int.Parse(Console.ReadLine()!);
string[] array = CreateArray(length);
PrintArrayElements(array, "с произвольным количеством символов");

ChangeArray(array);
PrintArrayElements(array, "с количеством символов, не превышающем 3");