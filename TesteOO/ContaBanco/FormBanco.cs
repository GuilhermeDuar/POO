using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace TesteOO.ContaBanco
{
    public partial class FormBanco : Form
    {
        public FormBanco()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContaBancaria contaGui = new ContaBancaria("1234", "12345678", "90090090090");
            ContaBancaria contaCelo = new ContaBancaria("4321", "87654321", "90090090090");

            RespostaOperacaoBancaria resposta = contaGui.Depositar(2000);

            contaGui.Transferir(500, contaCelo);

            //ContaBancaria cc = new ContaBancaria("1234", "12345678", "90090090090");
            //RespostaOperacaoBancaria resposta = cc.Depositar(1000);
            //MessageBox.Show(resposta.Mensagem);

            //cc.Sacar(50);
            //cc.Sacar(200);
            //cc.Sacar(300);

            // MessageBox.Show(cc.ImprimirExtrato());
        }
    }
}
