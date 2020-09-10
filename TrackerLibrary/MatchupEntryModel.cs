using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Representa uma equipa num encontro do torneio
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Representa o resultado do encontro
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Representa o ultimo encontro desta equipa como vencedora
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
