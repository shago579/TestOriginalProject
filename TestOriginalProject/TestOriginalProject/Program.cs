using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestOriginalProject.Figure;

namespace TestOriginalProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            var cuadrado = new Square(4.5m);
            var rectangulo = new Rectangle(4.5m, 2m);

            System.Console.WriteLine("Un cuadrado con un lado de 4.5 cm tiene de area: " + cuadrado.Area);
            System.Console.WriteLine("Un rectangulo con una base de 4.5 cm y una altura de 2 cm tiene de area: " + rectangulo.Area);
        }
    }
}
