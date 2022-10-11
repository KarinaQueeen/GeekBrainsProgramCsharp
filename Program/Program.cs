string [] GetNewArray (string [] array, int length)
{
    int newSize = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= length)
        {
            newSize++;
        }  
    }
    if (newSize == 0) Console.WriteLine($"В массиве нет элементов состоящих из {length} и менее символов!");

    string [] newArray = new string [newSize];

    for (int i = 0, k = 0; i < array.Length; i++)
    {
        if (array[i].Length <= length)
        {
                newArray [k] = array [i];
                k++;
        }
    }
    return newArray;
}

void PrintArray (string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine ($"{i + 1} элемент: {array [i]}\t");
    }
    return;
}

try
{
    Console.Write ("Введите количество элементов массива: ");
    int size = Convert.ToInt32 (Console.ReadLine ());

    string [] array = new string [size];
    for (int i = 0; i < size; i++)
    {
        Console.Write ($"Введите {i + 1} элемент массива: ");
        array [i] = Console.ReadLine ();
    }

    Console.Write ("Элементы, имеющие до какого количества символов будут выводиться: ");
    int lengthWord = Convert.ToInt32 (Console.ReadLine ());

    string [] newArray = GetNewArray (array, lengthWord);

    if (newArray.Length > 0)
    {
       Console.WriteLine ($"Элементы массива состоящие из {lengthWord} символов: ");
        PrintArray (newArray); 
    }
}
catch
{
   Console.Write ("Неверно введены данные!");
}


