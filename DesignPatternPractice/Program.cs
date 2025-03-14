// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices.JavaScript;
using DesignPatternPractice.Builder;
using DesignPatternPractice.ChainOfResponsibility;
using DesignPatternPractice.FactoryMethodPattern;
using DesignPatternPractice.Observer;
using DesignPatternPractice.RepositoryPattern;


var dough = new Dough.Builder().SetColor("red").SetThickness("2").Build();
var pizza = new Pizza.Builder();
var any = pizza.SetDough( ()=> new Dough.Builder().SetColor("red").SetThickness("2").Build()).SetSauce("sauce").Build();
Console.WriteLine($"{any.sauce} {any.dough.thickness} {any.dough.color}");


void Print(Action<string> some)
{
   some("khare gav");
}

void SayHello(string name)
{
    Console.WriteLine("Hello " + name);
}
Action<string> say = SayHello;
Print(say);