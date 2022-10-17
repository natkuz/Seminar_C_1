/* Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.WriteLine("Enter number N:");
int numberN = int.Parse(Console.ReadLine()!);
int i = 2;

if (numberN >= 2)
{
    Console.WriteLine("Even numbers from 1 to number N:");
    if (numberN % 2 == 0);
    {
                while (i <= numberN)
        {
            Console.WriteLine(i);
            i = i + 2;
        }
    }
    if (numberN % 2 != 0)
    {
        while (i <= numberN - 1)
        {
            Console.WriteLine(i);
            i = i + 2;
        }
    }
}
else
{
  Console.WriteLine("No even numbers from 1 to number N");  
}