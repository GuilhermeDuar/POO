using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteOO
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Profissional p = new Profissional();
            double valor = p.CalcularPrecoHoraServico();
            Profissional isadora = new Profissional();
            isadora.Altura = 1.58;
            isadora.CorDosOlhos = CorOlhos.Castanho;
            isadora.DataNascimento = new DateTime(2002, 10, 17);
            isadora.EhV = true;
            isadora.Etnia = Etnia.Europeia;
            isadora.Genero = Genero.Feminino;
            isadora.InformacoesCabelo = new Cabelo();
            isadora.InformacoesCabelo.CorDoCabelo = CorCabelo.Moreno;
            isadora.InformacoesCabelo.TamanhoDoCabelo = Tamanho.Grande;
            isadora.InformacoesCabelo.TipoDoCabelo = TipoCabelo.Liso;
            isadora.NomeGuerra = "Gretchen";
            isadora.Peso = 49;
            isadora.SemCapacete = true;
            isadora.Tamanho = Tamanho.Pequeno;
            isadora.TemLiberdade = true;
            isadora.TemS = true;
            isadora.TemT = true;

            Profissional guilherme = new Profissional();
            guilherme.Altura = 1.76;
            guilherme.CorDosOlhos = CorOlhos.Preto;
            guilherme.DataNascimento = new DateTime(1990, 11, 27);
            guilherme.EhV = false;
            guilherme.Etnia = Etnia.Indiana;
            guilherme.Genero = Genero.Masculino;

            guilherme.InformacoesCabelo = new Cabelo();
            guilherme.InformacoesCabelo.CorDoCabelo = CorCabelo.Moreno;
            guilherme.InformacoesCabelo.TipoDoCabelo = TipoCabelo.Liso;
            guilherme.InformacoesCabelo.TamanhoDoCabelo = Tamanho.Medio;

            guilherme.NomeGuerra = "Helicóptero de Combate";
            guilherme.Peso = 75;
            guilherme.SemCapacete = false;
            guilherme.Tamanho = Tamanho.Grande;
            guilherme.TemLiberdade = false;
            guilherme.TemS = false;
            guilherme.TemT = false;

            try
            {
                double precoIsadora = isadora.CalcularPrecoHoraServico();
                precoIsadora = isadora.CalcularPrecoHoraServico();
                double precoGuilherme = guilherme.CalcularPrecoHoraServico();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}
