// Console.WriteLine("Введите целое число");
// int num = Convert.ToInt32( Console.ReadLine() );
// int res = num * num;
// Console.WriteLine("Квадрат введенного числа равен "+res);

// if (num==5)
// {
//     Console.WriteLine("пятерочка!");
// }
// else if (num==3)
//      Console.WriteLine("троечка!");
// else 
//     Console.WriteLine("НЕ пятерочка и не троечка!");

// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет


Console.WriteLine ("Введите первое число");
int num = Convert.ToInt32( Console.ReadLine() );
Console.WriteLine ("Введите второе число");
int num2 = Convert.ToInt32( Console.ReadLine() );

if (num == num2*num2)
{
    Console.WriteLine("Верно");
}
else
    Console.WriteLine("Не верно");



