using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// Representa o nome dado ao encontro do torneio
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Representa o valor de entrada no registo 
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Representa listagem de equipas disponiveis para o encontro
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// Representa lista de prémios para o encontro
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// Representa lista com outra lista de encontros anteriores
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
