using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteOO.Forma_Geometrica
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
                Triangulo T = new Triangulo(20, 20, 30);
                MessageBox.Show(T.Perimetro.ToString());
                MessageBox.Show(T.Tipo.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
