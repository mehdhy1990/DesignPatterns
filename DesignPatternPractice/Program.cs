// See https://aka.ms/new-console-template for more information

using DesignPatternPractice.ChainOfResponsibility;
using DesignPatternPractice.RepositoryPattern;

Console.WriteLine("Hello, World!");
var system = new LegalCheckSystem();
var email = new Email("Hello from blood","the body of content contains blood ");
var isTrue= system.Check(email);
Console.WriteLine(isTrue);
