using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    class TeamModel
    {
        /// <summary>
        /// Representa conjunto de pessoas que estão linkados a uma equipa
        /// </summary>
        public List<PersonModel> TeamMeambers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// Representa o nome dado à equipa
        /// </summary>
        public string TeamName { get; set; }
    }
}
