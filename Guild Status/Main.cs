using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Guild_Status
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            var jObj = JsonHandler.ParseJsonObject("http://poe.pwx.me/api/ladder?league=omrtbhc&account=Miinistry");
            List<Character> characters = new List<Character>();
            foreach (dynamic entry in jObj)
            {
                dynamic values = entry.Value;
                int charLevel;
                var newCharacter = new Character
                {
                    Id = entry.Name,
                    Name = values["charName"],
                    Level = int.TryParse(values["level"].ToString(), out charLevel) ? charLevel : 0,
                };
                characters.Add(newCharacter);
            }

            //var obj =
            //    JsonHandler.ParseJson<JsonAccount>("http://poe.pwx.me/api/ladder?league=omrtbhc&account=Miinistry");
            //Console.WriteLine(obj);
        }

    }
}