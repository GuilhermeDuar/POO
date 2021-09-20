using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteOO.BrasFut
{
    public partial class FormFutebol : Form
    {
        public FormFutebol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Time t1 = TimeFactory.CreateTime();
            Time t2 = TimeFactory.CreateTime();

            Partida p = new Partida();
        }
    }
}
