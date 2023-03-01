using System;

namespace ConsoleApp1
{
    public class Shape
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Рисунок базового класса");
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Вызов переруженного метода, рисуем круг");
            base.Draw();
        }
    }

    /*
     * Данный код показывает все три принципа ООП
     * 1) Наследование: класс Circle наследуется от класса Shape
     * 2) Полиморфизм: метод Draw класса Circle перегружает метод Draw класса Shape
     * 3) Инкапсуляция: свойства X и Y имеют приватный сеттер, что запрещает присваивать этим свойствам значения извне
     */
}