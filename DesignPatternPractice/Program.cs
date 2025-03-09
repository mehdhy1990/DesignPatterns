// See https://aka.ms/new-console-template for more information

using DesignPatternPractice.ChainOfResponsibility;
using DesignPatternPractice.FactoryMethodPattern;
using DesignPatternPractice.Observer;
using DesignPatternPractice.RepositoryPattern;

Console.WriteLine("Hello, World!");
var messageSystem = new MessageSystem();

messageSystem.Attach(new EmailObserver(messageSystem));
messageSystem.Attach(new TextSystem(messageSystem));
messageSystem.Attach(new VideoSystem(messageSystem));

messageSystem.SetState("","");
// messageSystem.SetState("hello to email and text","");
messageSystem.SetState("","video is called");