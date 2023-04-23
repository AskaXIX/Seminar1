// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.Write("First number: ");
int first_number = Convert.ToInt32(System.Console.ReadLine());

System.Console.Write("Second number: ");
int second_number = Convert.ToInt32(System.Console.ReadLine());

System.Console.Write("Third number: ");
int third_number = Convert.ToInt32(System.Console.ReadLine());

int max = first_number;

if (first_number > max ) max = first_number;
if (second_number > max ) max = second_number;
if (third_number > max ) max = third_number;

System.Console.WriteLine($" Max = {max}");