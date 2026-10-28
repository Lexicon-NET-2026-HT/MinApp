using MinApp;
using System;

var calculator = new Calculator();

Console.WriteLine("Ange första talet:");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Ange andra talet:");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Summan är: {calculator.Add(a, b)}");
