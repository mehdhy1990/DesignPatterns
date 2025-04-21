// See https://aka.ms/new-console-template for more information

using DesignPatternPractice.AdapterDesignPattern;

Image image = new Image();
ImageView imageView = new(image);
imageView.Apply(new VividFiler());