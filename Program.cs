// Напишите программу, которая выводит третью цифру СЛЕВА заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 3267912 -> 6
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if(num > 99)
{
  while(num>999)
{
   num = num/10;
}
   Console.WriteLine($"Третье число{num%10}");
}
else
    Console.WriteLine("Третья цифра отсутствует");
       
    

