using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phasmophobia
{
    public class Ghost
    {
        public string name;
        public List<int> requiredItems = new List<int>(){0, 0, 0 };
        public Ghost(string name, int one, int two, int three)
        {
            this.name = name;
            requiredItems[0] = one;
            requiredItems[1] = two;
            requiredItems[2] = three;
        }
    }
}
