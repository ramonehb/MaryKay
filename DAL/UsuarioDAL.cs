using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsuarioDAL
    {
        public bool CadastraUsuario(Usuario usuario)
        {
            try
            {
                using (var db = new BaseDataContext())
                {
                    db.Usuarios.InsertOnSubmit(usuario);
                    db.SubmitChanges();
                    return true;
                }
            }
            catch (Exception ex )
            {
                var msg = ex.Message;
                return false;
            }
        }

        public bool AtualizarUsuario(Usuario usuario)
        {
            try
            {
                using (var db = new BaseDataContext())
                {
                    var usuarioDB = db.Usuarios.SingleOrDefault(u => u.ID_Usuario == usuario.ID_Usuario);
                    usuarioDB.ID_TipoUsuario = usuario.ID_TipoUsuario;
                    usuarioDB.Usuario1 = usuario.Usuario1;
                    usuarioDB.Senha = usuario.Senha;
                    usuarioDB.Email = usuario.Email;
                    usuarioDB.FL_Habilitado = usuario.FL_Habilitado;
                    db.SubmitChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
                return false;
            }
        }
        
        public bool DeletarUsuario(int idUsuario)
        {
            try
            {
                using (var db = new BaseDataContext())
                {
                    db.Usuarios.DeleteOnSubmit(db.Usuarios.Single(u => u.ID_Usuario == idUsuario));
                    return true;
                }
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
                return false;
            }
        }
    }
}
