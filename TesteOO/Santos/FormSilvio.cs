using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteOO.Santos
{
    public partial class FormSilvio : Form
    {
        public FormSilvio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Humano sergio = new Humano();
            sergio.Nome = "Sérgio";
            sergio.Idade = 32;

            Humano caio = new Humano();
            caio.Nome = "Caio";
            caio.Idade = 18;



            SilvioSantosCurse imortal = new SilvioSantosCurse();
            imortal.Enfeiticar1(sergio.Idade);
            imortal.Enfeiticar2(caio);
        }
    }
}
