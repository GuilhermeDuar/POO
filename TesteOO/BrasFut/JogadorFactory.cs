using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TesteOO.BrasFut
{
    class JogadorFactory
    {
        public static Jogador CreatGoleiro()
        {
            Random r = new Random();
            Goleiro g = new Goleiro();
            Time time = new Time();
            time.Nome = "Time " + (char)r.Next(65, 90);

            Zagueiro[] zagueiro = new Zagueiro[3];
            Centroavante[] atacantes = new Centroavante[3];
            Meia[] meias = new Meia[3];
            Volante[] volantes = new Volante[3];

            SetDados(g);


            for (int i = 0; i < zagueiro.Length; i++)
            {
                zagueiro[i] = new Zagueiro();
                SetDados(zagueiro[i]);
            }
            for (int i = 0; i < atacantes.Length; i++)
            {
                atacantes[i] = new Centroavante();
                SetDados(atacantes[i]);
            }
            for (int i = 0; i < meias.Length; i++)
            {
                meias[i] = new Meia();
                SetDados(meias[i]);
            }
            for (int i = 0; i < volantes.Length; i++)
            {
                volantes[i] = new Volante();
                SetDados(volantes[i]);
            }
            
            return g;
        }

        private static void SetDados(Jogador j)
        {
            Random r = new Random();
            //j.Nome = GerarNome;
            PropertyInfo[] propriedades = typeof(Jogador).GetProperties();
            foreach (PropertyInfo propriedade in propriedades)
            {
                if (propriedade.PropertyType == typeof(double) && propriedade.Name != "Altura")
                {
                    propriedade.SetValue(j, r.Next(30, 100));
                }
            }
            j.Altura = (double)r.Next(165, 201) / (double)100;
        }

    }
}
