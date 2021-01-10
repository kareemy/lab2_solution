using System;
using lab2_starter.Models;

namespace lab2_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Widget widgetOne = new Widget();
            widgetOne.Name = "Kareem";
            Console.WriteLine($"widgetOne.Name = {widgetOne.Name}");

            Widget widgetTwo = new Widget {Name = "Allie"};
            Console.WriteLine($"widgetTwo.Name = {widgetTwo.Name}");
        }
    }
}
