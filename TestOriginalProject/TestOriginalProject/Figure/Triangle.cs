using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOriginalProject.Figure
{
    public class Triangle
    {
        private decimal _lado1;
        private decimal _lado2;
        private decimal _lado3;

        private decimal _base;
        private decimal _altura;

        public decimal Base
        {
            get { return _base; }
            set { _base = value; }
        }

        public decimal Altura
        {
            get { return _altura; }
            set { _altura = value; }
        }

        public decimal Area
        {
            get { return (_base*_altura)/2; }
        }

        public decimal Perimetro
        {
            get { return _lado1 + _lado2 + _lado3; }
        }

        public Triangle(decimal lado1, decimal lado2, decimal lado3)
        {
            _lado1 = lado1;
            _lado2 = lado2;
            _lado3 = lado3;
        }
    }
}
