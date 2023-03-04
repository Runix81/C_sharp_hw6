// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Функция ввода данных пользователем

double Prompt(string msg)
{
    System.Console.Write($"{msg} -> ");
    double value;
    if (double.TryParse(Console.ReadLine(), out value))
    {
        return value;
    }
    System.Console.Write("Вы ввели не число");
    Environment.Exit(1);
    return 0;
}

double b1 = Prompt("Введите значение b1");
double k1 = Prompt("Введите значение k1");
double b2 = Prompt("Введите значение b2");
double k2 = Prompt("Введите значение k2");

double FindX(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}
double FindY(double b1, double k1, double x)
{
    double y = k1 * x + b1;
    return y;
}
System.Console.WriteLine($"Координаты пересечения двух прямых равны (X  {FindX(b1,k1,b2,k2)} | Y  {FindY(b1,k1,FindX(b1,k1,b2,k2))})");

