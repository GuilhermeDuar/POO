using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteOO.Jogo
{
    class Warrior : Hero, IWarriorSkills // se vc herda de uma classe abstrata vc deve implementar os metodos abs ou ser uma classe abs
    {
        public double Fury { get; private set; }
        private bool _isInBerserkForm;
        private int _turnsInBerserkForm;
        private double _strengthGainedWithberserk;
        private bool _bashIsInUse;
        private bool _IsIronSkinAtive;
        
        public override void LevelUp()
        {
            this.Strength += 10;
            this.Agility += 6;
            this.intelligence += 2;
            this.Vitality += 10;
            this.HP += 100;
            base.LevelUp();
        }
        public override double Attack(Hero heroAttacked)
        {
            double damage = this.Strength * 1.7 + this.Agility * 1.2;

            if (this._isInBerserkForm)
            {
                this._turnsInBerserkForm--;
                if (_turnsInBerserkForm == 0)
                {
                    this.Strength -= this._strengthGainedWithberserk;
                    this._isInBerserkForm = false;
                }
            }
            else
            {
                this.Fury += 10;

            }

            if (_bashIsInUse)
            {
                damage = damage * 3;
                this._bashIsInUse = false;
            }

            return heroAttacked.BeAttacked(damage,SourceDamage.Physical);
        }

        public override double BeAttacked(double damage, SourceDamage souce)
        {
            //calcula mitigação base -> defesa,resistencia e vitalidade
            double dmgAfterMitigation = base.BeAttacked(damage, souce);

            int seedEvasion = new Random().Next(0, 100);
            if (this.Evasion >seedEvasion )
            {
                return 0;
            }

            this.Fury += dmgAfterMitigation / 10;

            if (this._IsIronSkinAtive)
            {
                dmgAfterMitigation = dmgAfterMitigation * 0.1;
                this._IsIronSkinAtive = false;
            }
            
            this.HP -= dmgAfterMitigation;
            return dmgAfterMitigation;
        }
        public void Berserk()
        {
            this.Strength += this.Fury;
            this._strengthGainedWithberserk = this.Fury;
            this.Fury = 0;
            this._isInBerserkForm = true;
            this._turnsInBerserkForm = 5;
        }
        public void Bash()
        {
            if (this.Fury >= 100)
            {
                this.Fury -= 10 ;
                this._bashIsInUse = true;
            }
        }
        public void IronSkin()
        {
            if (this.Fury >= 50)
            {
                this.Fury -= 50;
                this._IsIronSkinAtive = true;
            }
        }
    }
}
