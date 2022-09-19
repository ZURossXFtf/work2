// See https://aka.ms/new-console-template for more information
//Захаров Иван Алексеевич 22-ИСП-2/2 Вариант 18

//Даны три переменные a, b и c. Изменить значения этих переменных так, чтобы в a хранилось значение a+b,
//в b хранилась разность старых значений c−a, а в c хранилось сумма старых значений a+b+c. Например, a = 0,
//b = 2, c = 5, тогда новые значения a=2, b = 3 и c=7.
using System;

try
{
Console.Write("Введите первую переменную:");
double a = double.Parse(Console.ReadLine());
Console.Write("Введите вторую переменную:");
double b = double.Parse(Console.ReadLine());
Console.Write("Введите третью переменную:");
double c = double.Parse(Console.ReadLine());

    double A = (a + b);
    double B = (c - (a+b));
    double C = (a + b + c);
    Console.WriteLine("А={0:F2},Б={1:F2},С={2:F2}", A,B,C);
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}