//Задача 15: Напишите программу, которая принимает 
//на вход цифру, обозначающую день недели, и проверяет, 
//является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите число");
int number= Convert.ToInt32(Console.ReadLine());
int Third (int num)
{
    if (num>5)
    {
        Console.WriteLine("выходной. (Да)");
    }
    else 
    {
        Console.WriteLine("раочий день. (Нет)");
    }
return num;
}
Third(number);
