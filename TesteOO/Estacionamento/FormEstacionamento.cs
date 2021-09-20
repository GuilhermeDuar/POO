using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteOO.Estacionamento
{
    public partial class FormEstacionamento : Form
    {
        public FormEstacionamento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Estacionamento estacionamento = new Estacionamento(100, 20);

            Ocupante oc = new Ocupante();
            oc.Nome = "Guilherme";
            oc.Placa = "1234-ABCD";
            oc.tipo = TipoVaga.Carro;

            Vaga v = new Vaga();

            estacionamento.Reservar(oc, v);
        }
    }
}
