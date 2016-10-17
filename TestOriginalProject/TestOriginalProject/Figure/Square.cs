using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOriginalProject.Figure
{
    public class Square
    {
        private decimal _lado;

        public decimal Lado
        {
            get { return _lado; }
            set { _lado = value; }
        }

        public decimal Area
        {
            get { return _lado*_lado; }
        }

        public decimal Perimetro
        {
            get { return _lado*4; }
        }

        public Square(decimal lado)
        {
            _lado = lado;
        }
    }
}
