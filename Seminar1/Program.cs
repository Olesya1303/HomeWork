// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
/*
Console.Write("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine("Первое число больше второго");
}
else if (number1 < number2)
{
    Console.WriteLine("Первое число меньше второго" );
}
else
{
    Console.WriteLine("Первое число равно второму");
}
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.Write("max =");
Console.WriteLine(max);
*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Input a number");
int num = Convert.ToInt32(Console.ReadLine());
if ((num % 2) == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число не четное");
}
*/

// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Input a number");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;

while(i <= n)
{
    if (i % 2 == 0)
    {
        Console.Write(i);
    }
    i++;
}
Console.Write("Четные числа");
*/