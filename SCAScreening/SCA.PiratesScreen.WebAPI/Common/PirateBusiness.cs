using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCA.PiratesScreen.WebAPI.Common
{
    //FYI: Using the Interface for Mock and/or Depdendency Injection
    public class PirateBusiness : IPirateBusiness
    {
        /// <summary>
        /// GetSmallestCoinAmount - Gets the smallest possible coin amount in the trunk, if the pirates shared the gold
        /// the way they do in the problem given on the SCA Screening site here: http://pirate.azurewebsites.net/
        /// </summary>
        /// <param name="numberOfPirates">number of pirates to share the way the problem states</param>
        /// <returns>int - smallest int that could have been in the trunk</returns>
        public ulong GetSmallestCoinAmount(int numberOfPirates)
        {
            double share = 0;

            if (numberOfPirates <= 0)
            {
                throw new ArgumentOutOfRangeException("numberOfPirates", "Number of Pirates must be 1 or more!");
            }

            share = Math.Pow(numberOfPirates ,(numberOfPirates + 1)) - numberOfPirates + 1;

            return (ulong)share;
        }
    }
}