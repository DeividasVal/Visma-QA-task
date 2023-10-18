using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visma_QA_task
{
    internal class BandMember
    {
        public string Name { get; }
        public string Role { get; }
        public BandMember(string name, string role)
        {
            Name = name;
            Role = role;
        }
    }
}
