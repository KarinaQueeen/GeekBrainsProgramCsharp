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
    if (newSize == 0) Console.WriteLine($"В массиве нет элементов состоящих из {lengthWord} и менее символов!");

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
        Console.Write ($"{i + 1}: {array [i]}\t");
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
    if (newArray.Length > 0)
    {
       Console.Write ("Элементы массива состоящие из 3 символов: ");
        PrintArray (newArray); 
    }
    
}
catch
{
   Console.Write ("Неверно введены данные!");
}


