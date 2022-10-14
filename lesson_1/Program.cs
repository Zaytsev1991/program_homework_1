//Задача 2
//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.Write("First number = ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Second number = ");
int n2 = Convert.ToInt32(Console.ReadLine());
if (n1>n2)
{
    Console.WriteLine("Max Number " + n1);
}
else
{
    Console.WriteLine("MaxNumber " + n2);
}
*/

//Задача 4
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

/*
Console.Write("number1 = ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("number2 = ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("number3 = ");
int n3 = Convert.ToInt32(Console.ReadLine());
if (n1>n2)
{
    if (n1>n3)
    {
        Console.WriteLine("Max Number " + n1);
    }
    else
    {
        Console.WriteLine("Max Number " + n3);
    }
}
else
{
    if (n2>n3)
    {
        Console.WriteLine("Max Number " + n2);
    }
    else
    {
        Console.WriteLine("Max Number " + n3);
    }
}
*/


//Задача 6
//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

/*
Console.Write("number = ");
int n = Convert.ToInt32(Console.ReadLine());
if (n % 2 == 0)
{
    Console.WriteLine("This number is even");
}
else
{
    Console.WriteLine("This number is odd");
}
*/

//Задача 8
//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

/*
Console.Write("N = ");
int N = Convert.ToInt32(Console.ReadLine());
int current = 2;
while(current <= N)
{
    Console.Write(current + " ");
    current += 2;
}
*/