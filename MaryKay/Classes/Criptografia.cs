using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MaryKay.Classes
{
    static class Criptografia
    {
        public static string Hash(string senha)
        {
            using (SHA256 hasher = SHA256.Create())
            {
                byte[] dados = hasher.ComputeHash(Encoding.UTF8.GetBytes(senha));
                var sBuilder = new StringBuilder();

                for (int i = 0; i < dados.Length; i++)
                {
                    sBuilder.Append(dados[i].ToString("X2"));
                }

                return sBuilder.ToString();
            }
        }
    }
}
