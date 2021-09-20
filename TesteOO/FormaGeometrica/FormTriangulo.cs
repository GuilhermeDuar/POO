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
    public partial class FormTriangulo : Form
    {
        public FormTriangulo()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(new Triangulo(int.Parse(txtLado1.Text), int.Parse(txtLado2.Text), int.Parse(txtLado3.Text)).ToString());
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message,"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
            }

        }
    }
}
    