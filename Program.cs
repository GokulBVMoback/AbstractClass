using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.AreaOf(4);
            Square square = new Square();
            square.AreaOf(5);
            Rectangle rectangle = new Rectangle();
            rectangle.AreaOfRect(3, 4);
        }
    }
}
