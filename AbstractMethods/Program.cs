using AbstractMethods.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace AbstractMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                List<Shape> Shapes = new List<Shape>();
                int n = 0;
                string cmd = "";
                Console.WriteLine("Insert the number of figures you want to create: (type \"exit\" to exit.)");

                try
                {
                    cmd = Console.ReadLine();
                    n = int.Parse(cmd);
                }
                catch
                {
                    if (cmd.ToLower() == "exit")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Insert only numbers or the command \"exit\" to exit.");
                        continue;
                    }
                }

                for (int i = 1; i <= n; i++)
                {
                    string choice = "";
                    Color color;
                    Console.WriteLine($"Shape #{i} info: ");

                    Console.WriteLine("Rectangle or circle?(r/c). Type \"clear\" to clear ");
                    try
                    {
                        choice = Console.ReadLine().ToLower();
                    }
                    catch
                    {
                        Console.WriteLine("Insert only text, please.");
                        i -= 1;
                        continue;
                    }

                    if (choice != "c" && choice != "r" && choice != "exit" && choice != "clear")
                    {
                        Console.WriteLine("Shape is invalid, choose between Circle(c) or Rectangle(r) or type \"exit\".");
                        i -= 1;
                        continue;
                    }
                    if (choice == "clear")
                    {
                        Console.Clear();
                        i -= 1;
                        continue;
                    }
                    Console.WriteLine("Pick the color: ");
                    foreach (Color ActualColor in (Color[])Enum.GetValues(typeof(Color)))
                    {
                        Console.WriteLine("-" + ActualColor.ToString());
                    }
                    Console.WriteLine();
                    try
                    {
                        color = Enum.Parse<Color>(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please write the name of the color you want on your shape.");
                        i -= 1;
                        continue;
                    }


                    if (choice == "r")
                    {
                        Console.WriteLine("Insert the width of the rectangle: ");
                        double width = double.Parse(Console.ReadLine());

                        Console.WriteLine("Now the height: ");
                        double height = double.Parse(Console.ReadLine());

                        Rectangle rect = new Rectangle(color, width, height);
                        Shapes.Add(rect);
                    }
                    else if (choice == "c")
                    {
                        Console.WriteLine("Insert the radius of the shape: ");
                        double radius = double.Parse(Console.ReadLine());
                        Circle circ = new Circle(color, radius);
                        Shapes.Add(circ);
                    }
                    else if (choice == "exit")
                    {
                        Environment.Exit(0);
                    }

                }

                foreach (Shape shape in Shapes)
                {
                    if (shape is Rectangle)
                    {
                        Console.WriteLine($"Rectangle: \n   Area = {shape.Area().ToString("F2", CultureInfo.InvariantCulture)} \n   Color = {shape.Color}");
                    }
                    else
                    {
                        Console.WriteLine($"Circle: \n   Area = {shape.Area().ToString("F2", CultureInfo.InvariantCulture)} \n   Color = {shape.Color}");
                    }
                }
            }
        }
    }
}
