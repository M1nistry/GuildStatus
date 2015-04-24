using System.Collections.Generic;

namespace Guild_Status.JSON
{
    public class JsonBeta
    {
        public class Datum
        {
            public string id { get; set; }
            public string name { get; set; }
            public string register_date { get; set; }
            public string forum_posts { get; set; }
            public string banned { get; set; }
            public string last_active { get; set; }
        }

        public class RootObject
        {
            public List<Datum> data { get; set; }
        }
    }
}
