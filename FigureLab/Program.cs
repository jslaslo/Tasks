using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();    
                Console.WriteLine("Добро пожаловать в программу!! \nВыберете площадь какой фигуры Вы хотите посчитать?\n 1) Круга;\n 2) Треугольника.");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {

                    case 1:
                        Console.WriteLine("Введите радиус круга...");
                        int radiusValue = Convert.ToInt32(Console.ReadLine());
                        Circle circle = new Circle(radiusValue);
                        Console.WriteLine($"Площадь круга = {circle.Square()}\nДля продолжения нажмите enter...");
                        Console.ReadLine();
                        break;

                    case 2:
                        int sideOne, sideTwo, sideThree;
                        Console.WriteLine("Введите значение стороны a = ...");
                        sideOne = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Введите значение стороны b = ...");
                        sideTwo = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Введите значение стороны c = ...");
                        sideThree = Convert.ToInt32(Console.ReadLine());

                        Triangle triangle = new Triangle(sideOne, sideTwo, sideThree);
                        Console.WriteLine($"Площадь треугольника = {triangle.Square()}");
                        Console.WriteLine($"Треугольник{(triangle.IsRight() ? " " : " не ")}прямоугольный\nДля продолжения нажмите enter...");
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Некорректное число. Повторите попытку снова...\nДля продолжения нажмите enter...");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
        
}
