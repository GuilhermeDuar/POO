using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteOO.BrasFut;
using TesteOO.Carros;
using TesteOO.ContaBanco;
using TesteOO.Estacionamento;
using TesteOO.Familia;
using TesteOO.Forma_Geometrica;
using TesteOO.Jogo;
using TesteOO.Santos;

namespace TesteOO
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormProva());
        }
    }
}
