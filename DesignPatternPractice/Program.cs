// See https://aka.ms/new-console-template for more information

using DesignPatternPractice.StatePattern;

var context = new Context(new OnState());
context.Request();
context.Request();
context.Request();