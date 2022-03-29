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
        /// Place Number of the team
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Place Name of the team
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Prize Amount in total
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Prize Percentage in total
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
