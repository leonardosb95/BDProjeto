using BDProjeto.Dominio;
using BDProjeto.RepositorioADO;
using Dominio.contrato;
using System.Collections.Generic;


namespace BDProjeto.Aplicacao
{
    public class UsuarioAplicacao
    {
        //private readonly UsuarioAplicacaoADO repositorio;// variavel de apenas leitura readonly
        private readonly IRepositorio<Usuarios> repositorio;

        public UsuarioAplicacao(IRepositorio<Usuarios> repo)
        {
            repositorio = repo;
        }


        public void Excluir(string id)
        {
            repositorio.Excluir(id);

        }

        public void Salvar(Usuarios usuario)
        {
            repositorio.Salvar(usuario);

        }

        public IEnumerable<Usuarios> ListarUsuarios(Usuarios usuario)
        {
            return repositorio.ListarUsuarios(usuario);
            
          
        }

        public Usuarios ListarUsuariosPorId(string id)
        {
            return repositorio.ListarUsuariosPorId(id);

        }




    }
}
