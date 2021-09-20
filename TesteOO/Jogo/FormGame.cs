using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteOO.Jogo
{
    public partial class FormGame : Form
    {
        public FormGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bag aNewBag = new Bag(4);

            aNewBag.addItem(1, "espada", 2);
            aNewBag.addItem(2, "escudo", 1);
            aNewBag.addItem(3, "arco", 1);
            aNewBag.addItem(4, "flecha", 33);
            aNewBag.removeItem(2);
            aNewBag.addItem(5, "Poção de Vida", 5);


        }
    }
}
