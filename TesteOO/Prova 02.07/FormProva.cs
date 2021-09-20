using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteOO.Prova_02._07;

namespace TesteOO
{
    public partial class FormProva : Form
    {
        public FormProva()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Retangulo retangulo = new Retangulo();
            if (String.IsNullOrWhiteSpace(txtAltura.Text) || String.IsNullOrWhiteSpace(txtBase.Text))
            {
                MessageBox.Show("Informe os valores.");
                return;
            }

            retangulo.Altura = double.Parse(txtAltura.Text);
            retangulo.Base = double.Parse(txtBase.Text);

            MessageBox.Show(retangulo.CalcularArea().ToString());


            EntradaCinema entradaCinema = new EntradaCinema("Nome do filme", 45, 7, 120);
            entradaCinema.CalcularValorAPagar(13);

            MessageBox.Show(entradaCinema.ValorDaEntrada.ToString("C2"));
        }
    }
}
