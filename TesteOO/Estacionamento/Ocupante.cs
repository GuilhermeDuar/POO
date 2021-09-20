using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteOO.Estacionamento
{
    class Ocupante
    {
        public string Nome { get; set; }
        public TipoVaga tipo { get; set; }
        public string Placa { get; set; }
        public DateTime HoraDeEntrada { get; set; }

        public Ocupante()
        {
            this.HoraDeEntrada = DateTime.Now;
        }
    }
}
