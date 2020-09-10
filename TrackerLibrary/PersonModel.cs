using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    class PersonModel
    {
        /// <summary>
        /// Primeiro nome de pessoa
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// ultimo nome de pessoa
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// email da pessoa
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// contacto telefonico da pessoa. 
        /// Considerado string, não é necessário tratar os dados introduzidos Matemáticamente
        /// </summary>
        public string CellphoneNumber { get; set; }
    }
}
