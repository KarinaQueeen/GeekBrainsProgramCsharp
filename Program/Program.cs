

try
{
    Console.Write ("Введите количество элементов массива: ");
    int num = Convert.ToInt32 (Console.ReadLine ());
    string [] array = new string [num];
    for (int i = 0; i < num; i++)
    {
        Console.Write ($"Введите {i + 1} элемент массива: ");
        array [i] = Console.ReadLine ();
    }
}
catch
{
   Console.Write ("Неверно введены данные!");
}


