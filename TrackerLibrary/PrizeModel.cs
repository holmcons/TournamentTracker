using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Represtents the number of place in the tournament.
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Represents the Name of the place in the tournament.
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Represents the amount of the prize.
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Represents the percentage of the prize.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
