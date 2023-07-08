// See https://aka.ms/new-console-template for more information

using System.Data;
using System.Reflection;
using ConsoleApp3;


var input = new ClassExeption();
Console.Write("Введите логин: ");
input.login = Console.ReadLine();
Console.Write("Введите пароль: ");
input.password = Console.ReadLine();
Console.Write("Поввторите пароль: ");
input.confrimPassword = Console.ReadLine();
ClassExeption.MethodExeption(input.login, input.password, input.confrimPassword);




