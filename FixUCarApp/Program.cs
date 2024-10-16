// See https://aka.ms/new-console-template for more information
using FixUCarApp;

Console.WriteLine("Welcome to calculator FixUCar");

var calculator = new Calculator();
var soma = calculator.addNumbers(2, 50);

Console.WriteLine(soma);
Console.ReadKey();
