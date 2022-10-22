/* Задача 10: Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

Console.WriteLine("Введите трехзначное число.");
    while(true)
    {
        string nambers = Console.ReadLine();
        if(nambers.Length == 3 )
        {
            Console.WriteLine( nambers[1]);
            
        }
        else
        {
            Console.WriteLine("Ошибка!! Введите трехзначное число.");
        }
                    
        break;
    }        

