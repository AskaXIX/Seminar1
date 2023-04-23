// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

System.Console.Write("Insert number: ");
int number = Convert.ToInt32(System.Console.ReadLine());

int result = number % 2;

if (result == 0)
{
    System.Console.WriteLine("Correct!");
}
else
{
    System.Console.WriteLine("Incorrect!");
}