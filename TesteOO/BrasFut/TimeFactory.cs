using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TesteOO.BrasFut
{
    class TimeFactory
    {
        public static Time CreateTime()
        {
            Random rdm = new Random();

            Time time = new Time();
            time.Nome = "Time " + (char)rdm.Next(65, 90);
            Goleiro g = new Goleiro();
            Zagueiro[] zagueiros = new Zagueiro[3];
            Volante[] volantes = new Volante[3];
            Meia[] meias = new Meia[2];
            Centroavante[] atacantes = new Centroavante[2];

            SetDados(g);
            for (int i = 0; i < zagueiros.Length; i++)
            {
                zagueiros[i] = new Zagueiro();
                SetDados(zagueiros[i]);
            }
            for (int i = 0; i < volantes.Length; i++)
            {
                volantes[i] = new Volante();
                SetDados(volantes[i]);
            }
            for (int i = 0; i < meias.Length; i++)
            {
                meias[i] = new Meia();
                SetDados(meias[i]);
            }
            for (int i = 0; i < atacantes.Length; i++)
            {
                atacantes[i] = new Centroavante();
                SetDados(atacantes[i]);
            }

            time.Escalar(g);
            time.Escalar(zagueiros);
            time.Escalar(volantes);
            time.Escalar(meias);
            time.Escalar(atacantes);
            return time;
        }

        private static void SetDados(Jogador j)
        {
            Random rdm = new Random();
            j.Nome = GerarNome();
            PropertyInfo[] propriedades = typeof(Jogador).GetProperties();
            foreach (PropertyInfo propriedade in propriedades)
            {
                if (propriedade.PropertyType == typeof(double) && propriedade.Name != "Altura")
                {
                    Thread.Sleep(1);

                    propriedade.SetValue(j, rdm.Next(30, 100));
                }
            }
            Thread.Sleep(1);
            j.Altura = (double)rdm.Next(165, 201) / (double)100;
        }

        private static string GerarNome()
        {
            string[] nomes =
            {
                "Aaran",
                "Tyllor",
                "Tylor",
                "Tymom",
                "Tymon",
                "Tymoteusz",
                "Tyra",
                "Tyree",
                "Tyrnan",
                "Tyrone",
                "Tyson",
                "Ubaid",
                "Ubayd",
                "Uchenna",
                "Uilleam",
                "Umair",
                "Umar",
                "Umer",
                "Umut",
                "Urban",
                "Uri",
                "Usman",
                "Uzair",
                "Uzayr",
                "Valen",
                "Valentin",
                "Valentino",
                "Valery",
                "Valo",
                "Vasyl",
                "Vedantsinh",
                "Veeran",
                "Victor",
                "Victory",
                "Vinay",
                "Vince",
                "Vincent",
                "Vincenzo",
                "Vinh",
                "Vinnie",
                "Vithujan",
                "Vladimir",
                "Vladislav",
                "Vrishin",
                "Vuyolwethu",
                "Wabuya",
                "Wai",
                "Walid",
                "Wallace",
                "Walter",
                "Waqaas",
                "Warkhas",
                "Warren",
                "Warrick",
                "Wasif",
                "Wayde",
                "Wayne",
                "Wei",
                "Wen",
                "Wesley",
                "Wesley-Scott",
                "Wiktor",
                "Wilkie",
                "Will",
                "William",
                "William-John",
                "Willum",
                "Wilson",
                "Windsor",
                "Wojciech",
                "Woyenbrakemi",
                "Wyatt",
                "Wylie",
                "Wynn",
                "Xabier",
                "Xander",
                "Xavier",
                "Xiao",
                "Xida",
                "Xin",
                "Xue",
                "Yadgor",
                "Yago",
                "Yahya",
                "Yakup",
                "Yang",
                "Yanick",
                "Yann",
                "Yannick",
                "Yaseen",
                "Yasin",
                "Yasir",
                "Yassin",
                "Yoji",
                "Yong",
                "Yoolgeun",
                "Yorgos",
                "Youcef",
                "Yousif",
                "Youssef",
                "Yu",
                "Yuanyu",
                "Yuri",
                "Yusef",
                "Yusuf",
                "Yves",
                "Zaaine",
                "Zaak",
                "Zac",
                "Zach",
                "Zachariah",
                "Zacharias",
                "Zacharie",
                "Zacharius",
                "Zachariya",
                "Zachary",
                "Zachary-Marc",
                "Zachery",
                "Zack",
                "Zackary",
                "Zaid",
                "Zain",
                "Zaine",
                "Zaineddine",
                "Zainedin",
                "Zak",
                "Zakaria",
                "Zakariya",
                "Zakary",
                "Zaki",
                "Zakir",
                "Zakk",
                "Zamaar",
                "Zander",
                "Zane",
                "Zarran",
                "Zayd",
                "Zayn",
                "Zayne",
                "Ze",
                "Zechariah",
                "Zeek",
                "Zeeshan",
                "Zeid",
                "Zein",
                "Zen",
                "Zendel",
                "Zenith",
                "Zennon",
                "Zeph",
                "Zerah",
                "Zhen",
                "Zhi",
                "Zhong",
                "Zhuo",
                "Zi",
                "Zidane",
                "Zijie",
                "Zinedine",
                "Zion",
                "Zishan",
                "Ziya",
                "Ziyaan",
                "Zohaib",
                "Zohair",
                "Zoubaeir",
                "Zubair",
                "Zubayr",
                "Zuriel"
            };
            Random rdm = new Random();
            int indice = rdm.Next(0, nomes.Length);
            Thread.Sleep(1);
            return nomes[indice];
        
        }


    }
}
