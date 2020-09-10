using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    class PrizeModel
    {
        /// <summary>
        /// Representa as diferentes posições em número dos prémios 
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Representa descrição em texto das posições dos prémios
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Representa aumento real do valor pré-estabelecido
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Representa aumento em % do valor pré-estabelecido
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
