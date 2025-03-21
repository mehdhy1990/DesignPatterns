// See https://aka.ms/new-console-template for more information

using DesignPatternPractice.VisitorDesignPattern;
using Microsoft.Extensions.DependencyInjection;

var element1 = new ConcreteElement1();
var element2 = new ConcreteElement2();

var vistor1 = new ConcreteVisitor1();
var vistor2 = new ConcreteVisitor2();

element1.Accept(vistor1);
element1.Accept(vistor2);

element2.Accept(vistor1);
element2.Accept(vistor2);
