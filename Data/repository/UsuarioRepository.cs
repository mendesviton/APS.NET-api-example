using Data.ContextWebApi;
using Data.model;
using Data.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.repository
{
    public class UsuarioRepository : BaseRepository<UsuarioModel>
    {
        public override string Create(UsuarioModel model)
        {
            model.password = Criptiografia.Criptografar(model.password);
            return base.Create(model);
        }

        public UsuarioModel Logon(string password, string email)
        {
            password = Criptiografia.Criptografar(password);
            UsuarioModel user = new UsuarioModel();
            using (WebApiContext context = new WebApiContext())
            {
                user = context.Usuario.Where(u=>u.email == email && u.password == password).FirstOrDefault();

            }
            return user;
        }
    }
}
