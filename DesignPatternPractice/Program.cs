// See https://aka.ms/new-console-template for more information

using DesignPatternPractice.Mediator;
using DesignPatternPractice.TemplateFactory;

// AbstractClass instance = new ConcreteClass1();
// instance.TemplateMethod();
Colleague1 colleague1 = new Colleague1();
Colleague2 colleague2 = new Colleague2();

ConcreteMediator mediator =   new ConcreteMediator(colleague2, colleague1);
