// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices.JavaScript;
using DesignPatternPractice.ChainOfResponsibility;
using DesignPatternPractice.FactoryMethodPattern;
using DesignPatternPractice.Observer;
using DesignPatternPractice.RepositoryPattern;



 void SayHello(Func<String> func)
{
    Console.WriteLine(func());
}

 string SaySomething()
 {
     return "fuck you from hello world";
 }
Func<string> say = SaySomething;
SayHello(say);
 