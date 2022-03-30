using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ClienteDAL
    {
        public bool CadastraCliente(Cliente cliente)
        {
            try
            {
                using (var db = new BaseDataContext())
                {
                    db.Clientes.InsertOnSubmit(cliente);
                    db.SubmitChanges();
                    return true;
                }
            }
            catch (Exception erro)
            {
                var msg = erro.Message;
                return false;
            }
        }

        public bool AtualizarCliente(Cliente cliente)
        {
            try
            {
                using (var db = new BaseDataContext())
                {
                    var clientes = db.Clientes.Single(c => c.ID_Cliente == cliente.ID_Cliente);
                    clientes.Nome = cliente.Nome;
                    clientes.CPF = cliente.CPF;
                    clientes.Email = cliente.Email;
                    clientes.DT_Nascimento = cliente.DT_Nascimento;
                    clientes.Telefone = cliente.Telefone;
                    clientes.Rua = cliente.Rua;
                    clientes.CEP = cliente.CEP;
                    clientes.Cidade = cliente.Cidade;
                    clientes.Estado = cliente.Estado;
                    clientes.NR_Logradouro = cliente.NR_Logradouro;
                    clientes.FL_EnviaEmail = cliente.FL_EnviaEmail;

                    db.SubmitChanges();
                    return true;
                }
            }
            catch (Exception erro)
            {
                var msg = erro.Message;
                return false;
            }
        }

        public bool DeletarCliente(int idCliente)
        {
            try
            {
                using (var db = new BaseDataContext())
                {
                    var cliente = db.Clientes.Single(c => c.ID_Cliente == idCliente);
                    db.Clientes.DeleteOnSubmit(cliente);
                    db.SubmitChanges();
                    return true;
                }
            }
            catch (Exception erro)
            {
                var msg = erro.Message;
                return false;
            }   
        }
    }
}
