// See https://aka.ms/new-console-template for more information

using System.Text;
using DesignPatternPractice.Strategy;

Order order = new("Banana",2,1000);
CSVExportService csvExportService = new();
XMLExportService xmlExportService = new();
JsonExportService jsonExportService = new();
order.ExportService = csvExportService;
order.Export();
order.ExportService = xmlExportService;
order.Export();