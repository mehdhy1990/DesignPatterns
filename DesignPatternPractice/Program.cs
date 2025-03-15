// See https://aka.ms/new-console-template for more information

using DesignPatternPractice.AdapterDesignPattern;
using DesignPatternPractice.StatePattern;

ITranslator translate = new Translator(new CzechLanguage());
translate.Translate();