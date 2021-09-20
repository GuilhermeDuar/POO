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
    public partial class FormAnotações : Form
    {
        public FormAnotações()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personagem p = new Personagem();
            p.EquiparArma(new Pexera());
            p.EquiparArma(new Glock());

            p.AtacarDeLonge();
            p.AtacarPerto();
        }
    }
}
