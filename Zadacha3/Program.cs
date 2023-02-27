// int start = 1;
// int finish = 30;

// while (start <= finish)
// {
//     Console.Write(start + " ");
//     start++;
// }


// Console.Write("Введите целое число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// num = Math.Abs(num);

// int negativeNum = Convert.ToInt32("-"+num);
// int count = negativeNum;

// while(count <= num){
//   Console.Write("{0} ", count);
//   count ++;
// }
// Console.WriteLine();

Console.Write("Введите трехзначное число: ");
int threeNum = Convert.ToInt32(Console.ReadLine());

int div = threeNum % 10;
Console.Write("Последняя цифра числа - {0}", div);

// Задача 7 HARD по желанию - идет за 2 необязательных Напишите программу, 
// которая принимает на вход целое число любой разрядности и на выходе показывает 
// третью цифру слева этого числа или говорит, что такой цифры нет. Через строку решать нельзя.
// 456111 -> 6
// 78 -> нет
// 9146548 -> 4     
// 3 -> нет