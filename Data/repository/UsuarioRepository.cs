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
    }
}
