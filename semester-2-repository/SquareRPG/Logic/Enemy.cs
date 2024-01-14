using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Enemy
    {
        // Properties
        public int Health { get { return _health; } }
        public int AttackPower { get { return _attackPower; } }

        // Fields
        int _health;
        int _attackPower;

        // Methods
        public Enemy(int health, int attackPower)
        {
            _health = health;
            _attackPower = attackPower;
        }

        public void LoseHealth(int damage)
        {
            _health -= damage;
        }
    }
}
