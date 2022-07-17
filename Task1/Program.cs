// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

void Zadacha41()
{
    Console.Write("Введите кол-во чисел, которое вы бы хотели ввести: ");
    int quantity = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    int number = 0;
    int count =0;
    

    while(number < quantity)
    {
        Console.Write("Введите число: ");
        int i = Convert.ToInt32(Console.ReadLine());
        if( i > 0)
        {
            count++;
            number++;
        }
        else number++;
        Console.WriteLine();
    }

    Console.WriteLine($"Количество чисел больше 0 равно: {count}");
}
Zadacha41();