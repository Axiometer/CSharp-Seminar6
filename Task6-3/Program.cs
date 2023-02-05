// Вывод int-массива в консоль
void WriteArrayToConsole(int[] intArray)
{
    for (int i = 0; i < intArray.Length; i++)
    {
        Console.Write(intArray[i] + " ");
        if (i != intArray.Length-1)
            Console.Write("; ");
    }
}
// Поиск двух максимумов
void FindMaximums(int[] intArray)
{
    int first = int.MinValue;
    int second = int.MinValue;

    for (int i=0; i < intArray.Length; i++)
    {
        if (intArray[i]>first && intArray[i]>second)
        {
            // Нашли максимум больше второго
            second=first;
            first=intArray[i];
        }
        else if (intArray[i]<first && intArray[i]>second)
        {
            // Нашли максимум между двух
            second = intArray[i];
        }
    }

    // Не знаю как передать оба параметр обратно из функции (без указателей)
    // либо без возрата массива
    // Поэтому выводим тут оба
    Console.Write($"first maximum={first}, second maximum={second}");
}

// Чтобы не мучаться с вводом или с генерацией рандома (для простоты)
// введем массив вручную
int[] array = new int[]{110,110,50,40,60,80,20,100,90};

WriteArrayToConsole(array);
Console.Write("\n");
FindMaximums(array);
