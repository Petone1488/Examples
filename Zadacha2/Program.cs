Console.Write("Введите номер дня недели (от 1 до 7): ");

try
{
  int num = Convert.ToInt32(Console.ReadLine());

  switch (num)
  {
    case 1:
      Console.WriteLine("Понедельник");
      break;
    case (2):
      Console.WriteLine("Вторник");
      break;
    case (3):
      Console.WriteLine("Среда");
      break;
    case (4):
      Console.WriteLine("Четверг");
      break;
    case (5):
      Console.WriteLine("Пятница");
      break;
    case (6):
      Console.WriteLine("Суббота");
      break;
    case (7):
      Console.WriteLine("Воскресенье");
      break;
    default:
      Console.WriteLine("Введенное число выходит за рамки семидневной недели");
      break;
  }
}
catch (System.FormatException)
{
  Console.WriteLine("Введено некорректное число");
}