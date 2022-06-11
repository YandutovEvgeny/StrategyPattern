using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Walk : IMoveble
    {
        public string Move()
        {
            return "\"я иду пешком\"";
        }
    }
}
