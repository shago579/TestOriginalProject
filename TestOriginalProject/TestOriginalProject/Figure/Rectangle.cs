using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOriginalProject.Figure
{
    public class Rectangle
    {
        public decimal Base { get; set; }

        public decimal Altura { get; set; }

        public decimal Area
        {
            get { return Base * Altura; }
        }

        public decimal Perimetro
        {
            get { return (Base * 2) * (Altura * 2); }
        }

        public Rectangle(decimal _base, decimal altura)
        {
            Base = _base;
            Altura = altura;
        }
    }
}
