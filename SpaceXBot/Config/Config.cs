﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceXBot.Config
{
    public class BotConfig
    {
        public string AppName { get; set; }
        public string AppUrl { get; set; }
        public string botID { get; set; }

        public Dictionary<string, ulong> OwnerIds { get; set; }
        public ulong[] RedditChannelIDs { get; set; }
        public ulong[] CountdownChannelIDs { get; set; }

        public static BotConfig CreateFromJson(string json)
        {
            return JsonConvert.DeserializeObject<BotConfig>(json);
        }
    }
}