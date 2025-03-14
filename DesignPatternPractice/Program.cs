// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices.JavaScript;
using DesignPatternPractice.Builder;
using DesignPatternPractice.ChainOfResponsibility;
using DesignPatternPractice.FactoryMethodPattern;
using DesignPatternPractice.Observer;
using DesignPatternPractice.RepositoryPattern;
using DesignPatternPractice.Strategy;


var context = new EnemyContext();
var batman = new Batman();
var superman = new Superman();
var thor = new Thor();
context.SetEnemy(thor);
context.Execute();