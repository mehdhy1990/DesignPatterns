// See https://aka.ms/new-console-template for more information

using DesignPatternPractice.CompositeDesignPattern;

var group = new Group();
var shape = new Shape();
group.AddComponent(shape);
group.AddComponent(shape);
var group2 = new Group();
group2.AddComponent(shape);
group2.AddComponent(shape);
group.AddComponent(group2);
group.Move();