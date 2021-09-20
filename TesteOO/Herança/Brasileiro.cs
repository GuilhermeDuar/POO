using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteOO.Heranca
{
    abstract class Poligno  // não pode ser estanciada
    {
        protected double[] Lados;
        public Poligno( double[] ladinhos)
        {
            this.Lados = ladinhos;
        }

        public abstract double CalcularArea();  //QUANDO UM METODO É ABSTRACT A CLASS TEM QUE SER TBM

        public double CalcularPerimetro()
        {
            return this.Lados.Sum();
        }
    }
    class Quadrilateros : Poligno
    {
        public Quadrilateros(double[] lados) : base(lados)
        {
            if (lados.Length != 4)
            {
                throw new Exception("Quadrilátero só podem conter 4 lados.");
            }
        }
        public override double CalcularArea()
        {
            return this.Lados[0] * this.Lados[1];
        }
    }

    class Triangulo : Poligno
    {
        public Triangulo(double[] lados) : base(lados)
        {
            if (lados.Length != 3)
            {
                throw new Exception("Triângulos só podem conter 4 lados.");
            }
        }

        public override double CalcularArea()
        {
            return Lados[0] * Lados[1] / 2;
        }
    }
    //---------------------------------------------------------------------

    class Brasileiro : Object // a class pai sempre herda de Object
    {
        public string CPF { get; set; }

        public virtual double Trabalhar() // virtual permite ser sobre escrito
        {
            return 3000;
        }
    }
    //---------------------------------------------------------------------

    class Rico : Brasileiro
    {
        public double ValorPesaoEx { get; set; }
        public double NomeEmbarcacao { get; set; }

        public override double Trabalhar() // override sobre escreve 
        {
            return base.Trabalhar() * 10;
        }
    }
    //---------------------------------------------------------------------

    class Pobre : Brasileiro
    {
        public int NumerDeDoencas { get; set; }
        public double ValorALuguel { get; set; }
        public double ValorFinanciamento { get; set; }

        public override double Trabalhar()
        {
            return base.Trabalhar() / 3;
        }
    }
    //---------------------------------------------------------------------
    interface ILadrao // NÃO PODE TER IMPLEMENTAÇÃO- SO SERVE ´RA ERANÇA MULTIPLA 
    {
        void Roubar(Brasileiro b);
        double ValorRoubado { get; set; }
    }
    //---------------------------------------------------------------------

    class Politico : Rico, ILadrao
    {
        public string Partido { get; set; }
        public double ValorDesviado { get; set; }
        public double ValorRoubado { get; set; }

        public void Roubar(Brasileiro b)
        {
            this.ValorRoubado = b.Trabalhar() * 0.3;
        }

        public override double Trabalhar()
        {
            return base.Trabalhar() * 2; // pega do rico
        }
    }
    //---------------------------------------------------------------------

    class Corinthiano : Pobre, ILadrao
    {
        public decimal PassagemPelaPolicia { get; set; }
        public string NomeGangue { get; set; }
        public double ValorRoubado { get; set; }

        public void Roubar(Brasileiro b)
        {
            if (b is Corinthiano)
            {
                return;
            }

            //brasileiro, rico, pobre, politico
            this.ValorRoubado += b.Trabalhar();  //     POLIMORFISMO
            if (b is Rico)
            {
                b = null;
            }
        }

        public override sealed double Trabalhar()
        {
            throw new Exception("Corinthiano não trabalha.");
        }
    }
    //---------------------------------------------------------------------

    class PresidioDosSonhos
    {
        public void Prender(ILadrao b)
        {
            if (b is Corinthiano)
            {

            }
        }
    }
    //---------------------------------------------------------------------

    class Isadora
    {
        public void Casar(Corinthiano c)
        {

        }
    }
    class Kmar
    {
        public void Casar(Rico r) // ou politico 
        {

        }
    }
    //---------------------------------------------------------------------

    class MyClass
    {
        public MyClass()
        {
            Brasileiro b = new Brasileiro();
            Rico r = new Rico();
            Pobre p = new Pobre();
            Politico pp = new Politico();
            Corinthiano c = new Corinthiano();

            //Isadora isa = new Isadora();  pq ela aceita BRASILEIRO aceita todoas que hendam dela 
            //isa.Casar(b);
            //isa.Casar(r);
            //isa.Casar(p);

            Isadora isa = new Isadora();
            isa.Casar(c);

            c.Roubar(pp);

            Triangulo tri = new Triangulo(new double[] { 4, 5, 3 });

            tri.CalcularArea();
            tri.CalcularPerimetro();
        }
    }
        




}
