using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.contrato
{
    //Vai herdar da classe generica
    public interface IRepositorio<T> where T:class
    {
        void Salvar(T entidade);

        void Excluir(string entidade);

        IEnumerable<T> ListarUsuarios(T entidade);

        T ListarUsuariosPorId(string id);

    }
}
