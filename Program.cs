using lab2_starter.Models;

Widget widgetOne = new Widget();
widgetOne.Name = "Kareem";
Console.WriteLine($"widgetOne.Name = {widgetOne.Name}");

Widget widgetTwo = new Widget {Name = "Allie"};
Console.WriteLine($"widgetTwo.Name = {widgetTwo.Name}");
