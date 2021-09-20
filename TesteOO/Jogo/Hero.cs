using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteOO.Jogo
{
    abstract class Hero
    {
        public double HP { get; set; }
        public double Strength { get; set; }
        public double Agility { get; set; }
        public double intelligence { get; set; }
        public double Level { get; private set; }
        public double Vitality { get; set; }

        public virtual void LevelUp()
        {
            this.Level++;
        }
        public double Defence
        {
            get
            {
                return this.Strength * 0.3;
            }
        }
        public double Resistance
        {
            get
            {
                return this.intelligence * 0.3;
            }
        }
        public double Evasion
        {
            get
            {
                return this.Agility * 0.1;
            }
        }

        public bool IsDead
        {
            get
            {
                return this.HP <= 0;
            }
        }

        public abstract double Attack(Hero hero);
        public virtual double BeAttacked(double damage, SourceDamage souce)
        {
            switch (souce)
            {
                case SourceDamage.Magical:
                    damage = damage - this.Resistance;
                    break;
                case SourceDamage.Physical:
                    damage = damage - this.Defence;
                    break;
            }
            return damage - this.Vitality * 1.2;
        }

    }
}
