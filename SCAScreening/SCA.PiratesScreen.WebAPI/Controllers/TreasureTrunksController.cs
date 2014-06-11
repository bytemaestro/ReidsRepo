using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using SCA.PiratesScreen.WebAPI.Common;
using SCA.PiratesScreen.WebAPI.Models; 

namespace SCA.PiratesScreen.WebAPI.Controllers
{
    public class TreasureTrunksController : ApiController
    {
         [Route("~/api/SCA/ForStep2/{piratesSharing:int}")]
         public IHttpActionResult GetSmallestTrunk(int piratesSharing)
         {
             PirateBusiness pirateHelper = new PirateBusiness();
             TreasureTrunk treasureTrunk = new TreasureTrunk();

             if (piratesSharing <= 0)
             {
                 throw new ArgumentOutOfRangeException("piratesSharing", "Number of Pirates Must Be 1 or More!");
             }

             treasureTrunk.PiratesSharing = piratesSharing;
             //get smallest possibile amount of coins in trunk
             treasureTrunk.TotalGoldCoins = pirateHelper.GetSmallestCoinAmount(treasureTrunk.PiratesSharing); 

             return Ok(treasureTrunk);
         }

        public TreasureTrunk GetTrunk(int id)
        {
            PirateBusiness piratesHelper = new PirateBusiness();
            TreasureTrunk treasureTrunk = new TreasureTrunk();

            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException("numberOfPirates", "Number of Pirates Must Be 1 or More!");
            }
            treasureTrunk.id = id;
            treasureTrunk.PiratesSharing = id;
            //get smallest possibile amount of coins in trunk
            treasureTrunk.TotalGoldCoins = piratesHelper.GetSmallestCoinAmount(treasureTrunk.PiratesSharing); 

            return treasureTrunk;
        }
       

    }
}
