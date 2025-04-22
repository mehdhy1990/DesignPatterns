// See https://aka.ms/new-console-template for more information

using DesignPatternPractice.DecoratorPattern;


var encrypt = new EncryptData(new CompressData(new CloudStream()));
Cloud(encrypt);

void Cloud(IStream data)
{
    data.Write("My name is mehdi");
}