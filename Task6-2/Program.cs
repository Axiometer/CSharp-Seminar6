// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем

double GetNumberFromUser(string message)   //Метод для ввода данных
{
    Console.Write(message);
    double res = double.Parse(Console.ReadLine()); //ввод с консоли и присваивание этого числа res
    return res;                     // возвращает значения
}

Console.WriteLine("Задайте коэффициенты прямых y1 = k1 * x + b1, y2 = k2 * x + b2:");

double b1 = GetNumberFromUser("Введите b1: ");
double k1 = GetNumberFromUser("Введите k1: ");
double b2 = GetNumberFromUser("Введите b2: ");
double k2 = GetNumberFromUser("Введите k2: ");

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine($"Точка пересечения прямых с коэффициентам b1={b1}, k1={k1}, b2={b2}, k2={k2}:\n({x}, {y})");
