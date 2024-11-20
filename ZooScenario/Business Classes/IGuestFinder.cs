using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooScenario
{
    public interface IGuestFinder
    {
        Guest FindGuest(string name);
    }
}
