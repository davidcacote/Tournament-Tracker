using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// Representa a lista que contém as equipas para esta ronda 
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Equipa vencedora do encontro do torneio
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Representa o número da ronda do encontro
        /// </summary>
        public int MatchupRound { get; set; }

    }
}
