// See https://aka.ms/new-console-template for more information

using DesignPatternPractice.RepositoryPattern;

Console.WriteLine("Hello, World!");
var controller = new Controller(new Repository());
controller.PrintData();