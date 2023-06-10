//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
//
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
//
//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29
using System;
using System.Threading;
Console.WriteLine("Привет пользователь!");
Thread.Sleep(1000);
string word = "Выбери что ты хочешь сделать:\nЗадача №1: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии..\nЗадача №2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.\nЗадача №3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.\nВаш выбор? \n";

foreach (char letter in word)
{
    Console.Write(letter);
    Thread.Sleep(25);
}

int chose;
chose = Convert.ToInt32(Console.ReadLine());
switch (chose)
{
    case 1:

        Console.WriteLine("Введите натуральное число больше 1:");
        int number = int.Parse(Console.ReadLine());
        void NumberCounter(int number)
        {
            if (number < 0) Console.Write($"{number} не натуральное число");
            if (number == 0) return;
            Console.Write("{0,4}", number);
            NumberCounter(number - 1);
        }

        NumberCounter(number);
        break;
    case 2:
        Console.Write("Введите число M: ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите число N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        SumFromMToN(m, n);

        void SumFromMToN(int m, int n)
        {
            Console.Write(SumMN(m - 1, n));
        }

        int SumMN(int m, int n)
        {
            int res = m;
            if (m == n)
                return 0;
            else
            {
                m++;
                res = m + SumMN(m, n);
                return res;
            }
        }
        break;
    case 3:
        Console.Write("Введите значение M: ");
int m3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n3 = Convert.ToInt32(Console.ReadLine());

int akkerman(int m3, int n3)
{
if (m3 == 0) return n3 + 1;
else if (n3 == 0) return akkerman(m3-1, 1);
else return akkerman(m3-1, akkerman(m3, n3-1));
}

Console.Write($"Функция Аккермана равно {akkerman(m3, n3)} ");
        break;
    default:
        Console.WriteLine("Выберете варианты 1-3");
        break;
}