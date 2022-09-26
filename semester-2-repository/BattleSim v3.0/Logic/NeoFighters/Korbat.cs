using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.NeoFighters
{
    public class Korbat : NeoFighter
    {
        public Korbat()
        {
            SetName(NeoFighterNames.Korbat);
            SetHealth(280);
            SetAttackPower(28);
            SetCritRatio(15);
        }

        public bool PoisonEnemy { get; private set; }

        public int Attack1_LifeSteal()
        {
            int attack = Attack(rnd, AttackPower);
            Heal(attack);
            return attack;
        }
        public int Attack2_Strychine(bool poisoned)
        {
            int attack = Attack(rnd, AttackPower);
            if (poisoned)
            {
                attack *= 2;
            }
            return attack;
        }
        public int Attack3_PoisonBite()
        {
            int attack = Attack(rnd, AttackPower);
            WillPoisonBitePoison();
            return attack;
        }

        void Heal(int stolenHealth)
        {
            SetHealth(Health + stolenHealth);
        }
        bool WillPoisonBitePoison()
        {
            PoisonEnemy = false;
            PoisonEnemy = ChanceToPoison();
            return PoisonEnemy;
        }
        bool ChanceToPoison()
        {
            int chanceToBite = rnd.Next(1, 101);
            if (chanceToBite <= 30)
            {
                return true;
            }
            return false;
        }
    }
}
