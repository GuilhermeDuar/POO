using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteOO
{
    public class Anotacoes
    {
        #region Variaveis
        private int variavel;
        #endregion

        #region Propriedades
        public string Propriedades { get; set; }

        public int PropriedadesEscritaPrivada { get; private set; }

        public string PropriedadeSomenteLeitura
        { 
          get
          {
                return "Implementação";
          }
        
        }
        #endregion

        #region Metodos
        public int AdicionarValorVariavelPrivada()
        {
            return this.PropriedadesEscritaPrivada = new Random().Next(0, 10);
        }
        public string Metodo()
        { 
           return "";
        }
        public static double OiEuSouUmMetodoStatic(int x, int y, int z)
        {
            return x + z + y;
        }
        #endregion

        #region Construtores
        public Anotacoes() //Construtor ct dois tabs
        {

        }
        public Anotacoes(int variavelPrivada, int propEscritaPrivada)
        {
            this.variavel = variavelPrivada;
            this.PropriedadesEscritaPrivada = propEscritaPrivada;
        }
        #endregion
        
    }

    abstract class Arma
    {
        public int QtdMaos { get; set; }
        public string Nome { get; set; }
        public double Peso { get; set; }
        public double Preco { get; set; }

        public abstract double CalcularIntervalo();
        public abstract double CalcularDano();
    }

    abstract class ArmaDeFogo : Arma
    {
        public int TamanhoDoPente { get; set; }
        public double Calibre { get; set; }
        public double Recuo { get; set; }
    }

    abstract class ArmaBranca : Arma
    {
        public FormaGolpe FormaDoGolpe { get; set; }
    }
    [Flags] // Pode ter varias opções
    public enum FormaGolpe
    {
        Estocada, Pancada, Cortada
    }

    class Pexera : ArmaBranca
    {
        public Pexera()
        {
            this.FormaDoGolpe = FormaGolpe.Cortada;
            this.Nome = "Pexera 666";
            this.Peso = 1;
            this.Preco = -1;
            this.QtdMaos = 2;
        }
        public override double CalcularDano()
        {
            return 999999999;
        }

        public override double CalcularIntervalo()
        {
            return 2;
        }
    }

    class Ak47 : ArmaDeFogo
    {
        public Ak47()
        {
            this.Nome = "AKzinha";
            this.Peso = 3.8;
            this.Preco = 20000;
            this.QtdMaos = 2;
            this.TamanhoDoPente = 40;
            this.Calibre = 7.62;
        }
        
        public override double CalcularDano()
        {
            return 30;
        }

        public override double CalcularIntervalo()
        {
            return 15;
        }
    }

    class Zweihander : ArmaBranca
    {
        public Zweihander()
        {
            this.Nome = "Zweihander";
            this.Peso = 7;
            this.Preco = 20000;
            this.QtdMaos = 2;
        }
        public override double CalcularDano()
        {
            return 50;
        }

        public override double CalcularIntervalo()
        {
            return 0.5;
        }
    }

    class Glock : ArmaDeFogo
    {
        public Glock()
        {
            this.Nome = "Glock";
            this.Peso = 3.8;
            this.Preco = 20000;
            this.QtdMaos = 1;
            this.TamanhoDoPente = 17;
            this.Calibre = 9.00;
        }
        public override double CalcularDano()
        {
            return 15;
        }

        public override double CalcularIntervalo()
        {
            return 15;
        }
    }
    //------------------------------------------------------------------------------------------
    class Personagem
    {
        public ArmaBranca ArmaBranca { get; private set; }
        public ArmaDeFogo ArmaDeFogo { get; private set; }

        public double AtacarPerto()
        {
            if (this.ArmaBranca == null)
            {
                return 0;
            }
            return this.ArmaBranca.CalcularDano();
        }
        public double AtacarDeLonge()
        {
            if (this.ArmaDeFogo == null)
            {
                return 0;
            }
            return this.ArmaDeFogo.CalcularDano();
        }

        public void EquiparArma(Arma arma)
        {
            if (arma is ArmaBranca)
            {
                if (arma.QtdMaos == 2)
                {
                    this.ArmaDeFogo = null;
                }
                this.ArmaBranca = (ArmaBranca)arma;
            }
            else
            {
                if (arma.QtdMaos == 2)
                {
                    this.ArmaBranca = null;
                }
                this.ArmaDeFogo = (ArmaDeFogo)arma;
            }
        }
    }
    class Myclass
    {
        public Myclass()
        {
            Anotacoes c = new Anotacoes();
            Anotacoes c1 = new Anotacoes(10,20);
            //c.PropriedadesEscritaPrivada = 10; --> não pode adicionar um valor em uma prop de set privado
            c.AdicionarValorVariavelPrivada();
            double a = Anotacoes.OiEuSouUmMetodoStatic(10,20,30);
        }

    }
}
