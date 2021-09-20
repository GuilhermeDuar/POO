using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteOO.Jogo
{
    class Mage : Hero, IMageSkills
    {
        public double Mana { get; set; }
        private bool _isFireBallAtive;
        private double _manaShieldValue;
        private bool _isManaTapActive;
        private double qntdManaInicial = 100;
        public Mage()
        {
            this.Mana = qntdManaInicial;
        }

        public override double Attack(Hero heroAttacked)
        {
            double damage = this.intelligence * 2;
            if (this._isFireBallAtive)
            {
                damage = damage * 3;
            }
            if (this._isManaTapActive)
            {
                this.Mana += 60;
            }
            return heroAttacked.BeAttacked(damage, SourceDamage.Magical);
        }

        public override double BeAttacked(double damage, SourceDamage souce)
        {
            double dano = base.BeAttacked(damage, souce);

            if (this._manaShieldValue != 0)
            {
                this._manaShieldValue -= damage;
                if (this._manaShieldValue < 0)
                {
                    this.HP += this._manaShieldValue;
                    this._manaShieldValue = 0;
                }
            }
            else
            {
                this.HP -= dano;
            }
            return dano;
        }

        public override void LevelUp()
        {
            this.Strength += 2;
            this.Agility += 3;
            this.intelligence += 15;
            this.Vitality += 5;
            this.HP += 60;
            base.LevelUp();
        }
        public void FireBall()
        {
            if (this.Mana >= 40)
            {
                this.Mana -= 40;
                this._isFireBallAtive = true;
            }
        }

        public void ManaShield()
        {
            this._manaShieldValue = this.Mana * 4;
            this.Mana = 0;
        }

        public void ManaTap()
        {
            this._isManaTapActive = true;
            this.HP = this.HP * 0.70;
        }
    }
}
