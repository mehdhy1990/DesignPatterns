﻿namespace DesignPatternPractice.VisitorDesignPattern;

public class ConcreteVisitor1 : Vistor
{
    public void Visit(ConcreteElement1 element)
    {
        var message = element.Operation();
        Console.WriteLine($"ConcreteVisitor1: {message}");
    }

    public void Visit(ConcreteElement2 element)
    {
        var message = element.Operation();
        Console.WriteLine($"ConcreteVisitor1: {message}");
    }
}