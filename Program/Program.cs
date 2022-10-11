string [] GetNewArray (string [] array)
{
    int newSize = 0;
    int lengthWord = 3;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= lengthWord)
        {
            newSize++;
        }
    }

    string [] newArray = new string [newSize];

    for (int i = 0, k = 0; i < array.Length; i++)
    {
        if (array[i].Length <= lengthWord)
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
        Console.Write ($"{array [i]}\t");
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
    string [] newArray = GetNewArray (array);
    Console.Write ("Элементы массива состоящие из 3 символов: ");
    PrintArray (newArray);
}
catch
{
   Console.Write ("Неверно введены данные!");
}


