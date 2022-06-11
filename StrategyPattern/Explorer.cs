using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    /// <summary>
    /// Паттерн стратегия позволяет менять поведение класса на ходу,
    /// в один момент времени класс может делать одно, а в другой момент времени 
    /// класс может делать другое
    /// </summary>
    class Explorer
    {
        public IMoveble Moveble { get; set; }
        public string Name { get; private set; }

        public Explorer(string name)
        {
            Moveble = new Walk();
            Name = name;
        }

        public string Move()
        {
            return $"{Name} говорит: " + Moveble.Move();
        }
    }
}
