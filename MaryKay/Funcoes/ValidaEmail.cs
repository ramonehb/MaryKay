using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaryKay.Funcoes
{
    public class ValidaEmail
    {
        public bool verificarEmail(string email)
        {
            var erro = 0;
            if (string.IsNullOrEmpty(email))
            {
                erro++;
            }
            
            if (!email.Contains(".COM") && !new EmailAddressAttribute().IsValid(email))
            {
                erro++;
            }

            return erro == 0;
        }
    }
}
