using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCA.PiratesScreen.WebAPI.Models
{
    public class TreasureTrunk
    {
        public int id { get; set; }
        public ulong TotalGoldCoins { get; set; }
        public int PiratesSharing { get; set; }

    }
}