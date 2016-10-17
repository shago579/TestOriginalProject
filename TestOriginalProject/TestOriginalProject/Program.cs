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

            System.Console.WriteLine("Un cuadrado con un lado de 4.5 cm tiene de area: " + cuadrado.Area);
            
        }
    }
}
