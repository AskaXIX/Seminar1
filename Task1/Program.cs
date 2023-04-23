// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int a = 5, b = 7,
    c = 2, d = 10,
    e = -9, f = -3;

int first_max = a,
    second_max = c,
    third_max = e;

if (a > first_max ) first_max = a;
if (b > first_max ) first_max = b;

System.Console.WriteLine($"1. {a} ~ {b}?");
System.Console.WriteLine($"   Max = {first_max}");

if (c > second_max ) second_max = c;
if (d > second_max ) second_max = d;

System.Console.WriteLine($"2. {c} ~ {d}?");
System.Console.WriteLine($"   Max = {second_max}");

if (e > third_max ) third_max = e;
if (f > third_max ) third_max = f;

System.Console.WriteLine($"3. {e} ~ {f}?");
System.Console.WriteLine($"   Max = {third_max}");