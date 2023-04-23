// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int a = 2, b = 3, c = 7,
    a1 = 44, b1 = 5, c1 = 78,
    a2 = 22, b2 = 3, c2 = 9;

int first_max = a,
    second_max = a1,
    third_max = a2;

if (a > first_max) first_max = a;
if (b > first_max) first_max = b;
if (c > first_max) first_max = c;

System.Console.WriteLine($"1. {a} ~ {b} ~ {c}?");
System.Console.WriteLine($"   Max = {first_max}");

if (a1 > second_max) second_max = a1;
if (b1 > second_max) second_max = b1;
if (c1 > second_max) second_max = c1;

System.Console.WriteLine($"2. {a1} ~ {b1} ~ {c1}?");
System.Console.WriteLine($"   Max = {second_max}");

if (a2 > third_max) third_max = a2;
if (b2 > third_max) third_max = b2;
if (c2 > third_max) third_max = c2;

System.Console.WriteLine($"3. {a2} ~ {b2} ~ {c2}?");
System.Console.WriteLine($"   Max = {third_max}");

//Так же альернативный код:

// System.Console.Write("First number: ");
// int first_number = Convert.ToInt32(System.Console.ReadLine());

// System.Console.Write("Second number: ");
// int second_number = Convert.ToInt32(System.Console.ReadLine());

// System.Console.Write("Third number: ");
// int third_number = Convert.ToInt32(System.Console.ReadLine());

// int max = first_number;

// if (first_number > max ) max = first_number;
// if (second_number > max ) max = second_number;
// if (third_number > max ) max = third_number;

// System.Console.WriteLine($" Max = {max}!");