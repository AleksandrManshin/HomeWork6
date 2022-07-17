// Задача 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void Zadacha43()
{
    Console.WriteLine("Две прямые заданы уравнениями y=k1*x+b1 и y=k2*x+b2.");
    Console.WriteLine("Задайте значения переменных k1, k2, b1, b2.");
    Console.Write("k1: ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("k2: ");
    double k2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("b1: ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("b2: ");
    double b2 = Convert.ToDouble(Console.ReadLine());
    
    Console.WriteLine($"Точка пересечения двух прямых: {(FindX(k1, k2, b1, b2), FindY(FindX(k1, k2, b1, b2), k1, b1))}");
}

double FindX(double k1, double k2, double b1, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double FindY(double x, double k1, double b1)
{
    double y = k1 * x + b1; 
    return y;
}

Zadacha43();