// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
    // 5 -> 2, 4
    // 8 -> 2, 4, 6, 8
// *Число "0" является чётным ))
Console.WriteLine("Чётные числа от 1 до N");
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number = -number;
    string znak = "-";
    System.Console.WriteLine($"Вы ввели отрицательное число: {znak}{number}. Результат программы выведет значения по модулю"); 
}
    int i = 0;
    while (i < number)
    {
        if(i%2 == 0)
        {
            System.Console.Write($"{i} "); // Вывод чётных чисел.
        }
        i++;
       
    }