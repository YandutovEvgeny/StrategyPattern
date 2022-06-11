using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Fly : IMoveble
    {
        public string Move()
        {
            return "\"я лечу на самолёте\"";
        }
    }
}
