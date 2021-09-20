using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteOO
{
    public class Triangulo
    {
        public int Lado1 { get; private set; }
        public int Lado2 { get; private set; }
        public int Lado3 { get; private set; }
        public TiposTriangulo TipoDoTriangulo
        {
            get
            {
                if (this.Lado1 == this.Lado2 && this.Lado1 == this.Lado3)
                {
                    return TiposTriangulo.equilátero;
                }
                else if (this.Lado1 != this.Lado2 && this.Lado1 != this.Lado3)
                {
                    return TiposTriangulo.escaleno;
                }
                return TiposTriangulo.isósceles;
            }
        }
        public double Perimetro
        {
            get  
            {
                return this.Lado1 + this.Lado2 + this.Lado3;
            }
        }
        public Triangulo(int l1, int l2, int l3)
        {
            if (l1 >= l2 + l3 || l2 >= l1 + l3 || l3 >= l1 + l2)
            {
                throw new Exception("Não é permitido que um lado seja maior que a soma dos outros.");
            }
            this.Lado1 = l1;
            this.Lado2 = l2;
            this.Lado3 = l3;
        }
        public override string ToString()
        {
            return string.Format("Lados atribuídos: {0}, {1}, {2}. \r\n" + "Tipo de triangulo: {3}. \r\n" + "Perimetro: {4}.",
            Lado1, Lado2, Lado3, TipoDoTriangulo, Perimetro.ToString("N2"));
        }
            
    }
}
