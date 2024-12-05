using System;
using System.Reflection.Emit;

namespace Mod2_C
{
    class Programm
    {
        enum Figures { Romb, Circle, Rect }

        struct Fdata
        {
            public int x0, y0;      // координаты центра тяжести
            public int color;   // цвет фигуры
            public Figures type;    // тип фигуры
        }

        static void Main()
        {
            Fdata fd = new Fdata()
            {
                x0 = 1,
                y0 = 1,
                color = 0x272700,
                type = Figures.Circle
            };
            Console.WriteLine($"x0:={fd.x0}, y0:={fd.y0}, color:={fd.color}, type:= {fd.color}");
        }
    }

}



