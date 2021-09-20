using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteOO.Familia
{
    public partial class FormFamilia : Form
    {
        public FormFamilia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mae mariaInes = new Mae();
            mariaInes.Nome = "Maria Inês";
            PaiFumante luiz = new PaiFumante();
            luiz.Nome = "Luiz";

            Filho filho = mariaInes.EngravidarDe(luiz);

            MessageBox.Show("Test");
        }
    }
}
