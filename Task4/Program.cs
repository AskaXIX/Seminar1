// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.WriteLine("Insert number: ");
int number = Convert.ToInt32(System.Console.ReadLine());

while (number > 1)
{
    if (number % 2 == 0)
    {
        System.Console.WriteLine(number);
        number = number - 1;
    }
    else
    {
        number = number - 1;
    }
}