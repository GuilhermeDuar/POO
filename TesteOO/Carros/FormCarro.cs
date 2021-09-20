using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteOO.Carros
{
    public partial class FormCarro : Form
    {
        public FormCarro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Carro fiesta = new Carro(temABS: false,
                                     modelo: "Fiest 1.0",
                                     marca: "Ford",
                                     motor: new Motor(63, false));

            Carro golf = new Carro(temABS: true,
                                   modelo: "GOLF GTI",
                                   marca: "VW",
                                   motor: new Motor(221, true));

            for (int i = 0; i < 10; i++)
            {
                fiesta.Acelerar();
                golf.Acelerar();
            }

            for (int i = 0; i < 10; i++)
            {
                fiesta.Frear();
                golf.Frear();
            }
        }
    }
}
