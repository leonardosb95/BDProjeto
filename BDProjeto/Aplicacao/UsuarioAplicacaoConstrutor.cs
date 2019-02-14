using BDProjeto.Aplicacao;
using BDProjeto.RepositorioADO;

namespace Aplicacao
{
    public class UsuarioAplicacaoConstrutor
    {
        //Refatoração a instancia da classe UsuarioAplicacao
        public static UsuarioAplicacao usuarioApADO()
        {
            return new UsuarioAplicacao(new UsuarioAplicacaoADO());
        }

    }
}
