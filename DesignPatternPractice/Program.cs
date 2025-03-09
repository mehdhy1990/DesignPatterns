// See https://aka.ms/new-console-template for more information

using DesignPatternPractice.ChainOfResponsibility;
using DesignPatternPractice.FactoryMethodPattern;
using DesignPatternPractice.RepositoryPattern;

Console.WriteLine("Hello, World!");
var BmwFactory = new BMW();
var Bmwcar = BmwFactory.CreateCar();
var BenzFactory = new Benz();
var BenzCar = BenzFactory.CreateCar();