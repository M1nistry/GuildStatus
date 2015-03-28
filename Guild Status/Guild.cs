using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild_Status
{
    internal class Guild
    {
        internal string Name { get; set; }
        internal string Tag { get; set; }
        internal string Status { get; set; }
        internal string Created { get; set; }
        internal int TotalMembers { get; set; }
        internal List<string> Members { get; set; } 
    }
}
