// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

// Вывод int-массива в консоль
void WriteArrayToConsole(int[] intArray)
{
    Console.Write("Исходный массив: ");
    for (int i = 0; i < intArray.Length; i++)
    {
        Console.Write(intArray[i] + " ");
        if (i != intArray.Length-1)
            Console.Write("; ");
    }
    Console.WriteLine();
}

// Ввод числа пользователем
int GetNumberFromUser(string message)  //метод ввода числа
{
    while(true)     
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect)       
            return userNumber;
        Console.WriteLine("Ошибка ввода!");
    }
}

// Ввод массива пользователем
int[] GetArrayFromUser(int size)        //метод создания массива
{
    int[] result = new int[size];

    for (int i = 1; i < size+1; i++)
        result[i-1] = GetNumberFromUser($"Введите {i} число массива: ");;
    
    return result;
}

// Подсчет положительных в массиве
int CountPositiveNumbers(int[] array)     //вычисление количества положительных чисел
{
    int count = 0;
    int i = 0;
    while (i < array.Length)
    {
        if(array[i] > 0) count++;
        i++;
    }
    return count;
}

int size = GetNumberFromUser("Введите размер массива: ");
int[] array = GetArrayFromUser(size);
int countpositive = CountPositiveNumbers(array);
WriteArrayToConsole(array);
Console.Write($"Количество положительных чисел в массиве = {countpositive}");