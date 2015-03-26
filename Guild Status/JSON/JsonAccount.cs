using Newtonsoft.Json;

namespace Guild_Status.JSON
{
    public class Wrapper
    {
        public JsonAccount JsonAccount { get; set; }
    }
        public class JsonAccount
        {
            
            public string lastOnline { get; set; }
            [JsonProperty("experience")]
            public string experience { get; set; }
            public int xp_from_bottom { get; set; }
            public string total_characters_on_ladder { get; set; }
            public string id { get; set; }
            public string updated { get; set; }
            public string movedRanks { get; set; }
            public string lastRank { get; set; }
            public int levels_from_bottom { get; set; }
            public string xpGain { get; set; }
            public string updatedHuman { get; set; }
            public string level { get; set; }
            public string @class { get; set; }
            public string charName { get; set; }
            public string onlineTime { get; set; }
            public string lastOnlineHuman { get; set; }
            public string xph { get; set; }
            public string dead { get; set; }
            public int levels_from_top { get; set; }
            public string historyid { get; set; }
            public object dupe { get; set; }
            public string online { get; set; }
            public int xp_from_top { get; set; }
            public string league { get; set; }
            public string rank { get; set; }
            public string accountName { get; set; }
        }

    public class RootObject
    {
        public JsonAccount RootAccount { get; set; }
    }

        //public class MiinistryAbbottxoth
        //{
        //    public string lastOnline { get; set; }
        //    public string experience { get; set; }
        //    public int xp_from_bottom { get; set; }
        //    public string total_characters_on_ladder { get; set; }
        //    public string id { get; set; }
        //    public string updated { get; set; }
        //    public string movedRanks { get; set; }
        //    public string lastRank { get; set; }
        //    public int levels_from_bottom { get; set; }
        //    public string xpGain { get; set; }
        //    public string updatedHuman { get; set; }
        //    public string level { get; set; }
        //    public string @class { get; set; }
        //    public string charName { get; set; }
        //    public string onlineTime { get; set; }
        //    public string lastOnlineHuman { get; set; }
        //    public string xph { get; set; }
        //    public string dead { get; set; }
        //    public int levels_from_top { get; set; }
        //    public string historyid { get; set; }
        //    public object dupe { get; set; }
        //    public string online { get; set; }
        //    public int xp_from_top { get; set; }
        //    public string league { get; set; }
        //    public string rank { get; set; }
        //    public string accountName { get; set; }
        //}

        //public class RootObject
        //{
        //    public MiinistryAbbottxoth Abbottxoth { get; set; }
        //}
}
