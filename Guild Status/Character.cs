using System;

namespace Guild_Status
{
    internal class Character
    {
        internal string Id { get; set; }
        internal string Name { get; set; }
        internal string Account { get; set; }
        internal int Level { get; set; }
        internal Int64 Experience { get; set; }
        internal DateTime LastOnline { get; set; }
        internal bool Online { get; set; }
        internal int Rank { get; set; }
        internal bool Dead { get; set; }
        internal string Class { get; set; }


    }
}
