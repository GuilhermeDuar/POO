using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteOO.Estacionamento
{
    class Estacionamento
    {
        private List<Vaga> vagas;

        public Estacionamento(int totalVagas, int vagasPorAndar)
        {
            this.vagas = VagaFactory.CreateVagas(totalVagas, vagasPorAndar);
        }

        public Vaga Reservar(Ocupante ocupante, Vaga vaga)
        {
            if (ocupante.tipo != vaga.Tipo)
            {
                throw new Exception("Seu veículo não bate com a vaga selecionada.");
            }
            
            foreach (Vaga v in this.vagas)
            {
                if (v.Coberta == vaga.Coberta && v.Segurada == vaga.Segurada && v.TemCharge == vaga.TemCharge && v.Cliente == null)
                {
                    v.Cliente = ocupante;
                    return v;
                }
            }
            throw new Exception("Vaga não encontrada."); // deveria fazer uma classe que tenha como parametro uma mensagem
        }

        public double DarSaida(string placa)
        {
            List<Vaga> vaga = new List<Vaga>();
            foreach (Vaga v in this.vagas)
            {
                // v.Cliente != null && v.Client.Placa == placa
                if (v.Cliente?.Placa == placa)
                {
                    DateTime horaEntrada = v.Cliente.HoraDeEntrada;
                    DateTime horaSaida = DateTime.Now;
                    TimeSpan ts = horaSaida.Subtract(horaEntrada);
                    int totalHoras = (int)ts.TotalHours;
                    if (totalHoras == 0 )
                    {
                        totalHoras++;
                    }
                    return totalHoras * v.Preco;
                }
            }
            throw new Exception("Veículo não encontrado.");




        }
    }
}
