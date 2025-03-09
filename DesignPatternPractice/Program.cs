// See https://aka.ms/new-console-template for more information

using DesignPatternPractice.ChainOfResponsibility;
using DesignPatternPractice.FactoryMethodPattern;
using DesignPatternPractice.RepositoryPattern;

Console.WriteLine("Hello, World!");
var bmwFactory = new BMW();
var bmwCar = bmwFactory.CreateCar();
var benzFactory = new Benz();
var benzCar = benzFactory.CreateCar();