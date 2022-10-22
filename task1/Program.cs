/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6   */

Console.WriteLine("Введите цифры:");
int nambers = Convert.ToInt32(Console.ReadLine());
int count = 1;
int namber = nambers;
int result = 0;

    while ((namber /= 10) > 1) 
    {
        ++count;
    }
// Console.WriteLine(count);//

    if(count < 3 )
    {
      Console.WriteLine("Третьей цифры нет");
    }

    else if (count == 3)
    {
        result = nambers % 10;
        Console.WriteLine(result);
    }

    else
    {
        int c = 1;
        for (int i = count; i > 3; i--)
        {
            c = c * 10;
        }
        result = (nambers / c) % 10;
        Console.WriteLine(result);    
    }    
