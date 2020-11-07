using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhasmophobiaGhostAssistant
{
    public class Ghost
    {
        public string name;
        public string strength;
        public string weakness;
        public List<int> requiredItems = new List<int>(){0, 0, 0 };
        public Ghost(string name,string strength,string weakness, int one, int two, int three)
        {
            this.name = name;
            this.strength = strength;
            this.weakness = weakness;
            requiredItems[0] = one;
            requiredItems[1] = two;
            requiredItems[2] = three;
        }
    }
}
