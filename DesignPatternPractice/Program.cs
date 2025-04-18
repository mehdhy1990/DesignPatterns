// See https://aka.ms/new-console-template for more information

using System.Text;
using DesignPatternPractice.CommandPattern;
using DesignPatternPractice.StatePattern;
using DesignPatternPractice.Strategy;

Canvas canvas = new Canvas();
BrushTool brushTool = new BrushTool();
SelectionTool selectionTool = new SelectionTool();
canvas.Tool = brushTool;
canvas.MouseDown();
canvas.MouseUp();
canvas.Tool = selectionTool;
canvas.MouseDown();
canvas.MouseUp();