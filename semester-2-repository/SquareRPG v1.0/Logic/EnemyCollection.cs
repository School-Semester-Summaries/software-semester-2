using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class EnemyCollection
    {
        // Properties
        public List<Enemy> EnemyList { get { return _enemyList; } }

        // Fields
        List<Enemy> _enemyList = new List<Enemy>();

        public void AddEnemy(Enemy enemy)
        {
            _enemyList.Add(enemy);
        }
    }
}
