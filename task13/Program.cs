//Задача 13: Напишите программу, которая выводит третью 
//цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число");
int number= Convert.ToInt32(Console.ReadLine());
int Third (int num)
{
    int result=-1;
    if (num >=100)
    {
     while (num > 999)
     {
        num = num / 10;
     }
        result = num % 10;
    }
 
return result; 
}
 
if (Third(number) == -1)
Console.WriteLine("Третьей цифры нет");
else
Console.WriteLine($" Третья цифра -> {Third(number)}");
