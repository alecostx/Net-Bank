using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBank.Domain.Models.Requests
{
    public class GetUserRequest
    {
        /// <summary>
        /// Código de identificação do usuário
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// Nome do usuário
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Email do usuário
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Documento de identificação do usuário [CPF/CNPJ]
        /// </summary>
        public string Document { get; set; }
    }
}
