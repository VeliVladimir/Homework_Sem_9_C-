// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using System;
using static System.Console;

Clear ();
int n = InputInt ("Введите положительное число:");
int m = 1;
if ( n < 1)
{
    WriteLine ("Введено неположительное число");
}
WriteLine ( NaturalNumber ( n, m ));

int NaturalNumber ( int n, int m )
{
    if ( n==m )
        return n;
    else 
        WriteLine ($"{NaturalNumber (n, m + 1)}, ");
    return m;
}

int InputInt (string output)
{
    Write (output);
    return int.Parse ( ReadLine());
}