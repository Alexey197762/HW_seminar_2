/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
 и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */
Console.WriteLine("Напишите число дня недели от 1 до 7:");
int namber = Convert.ToInt32(Console.ReadLine());
if(namber >= 1  || namber < 8)
{
   if(namber == 6 || namber == 7)
{
    Console.WriteLine("ДА, выходной.");
}
else
{
    Console.WriteLine("Не выходной.");
} 
}
else
{
    Console.WriteLine("Ошибка.");
}

