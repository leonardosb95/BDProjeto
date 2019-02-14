using System;
using BDProjeto.Dominio;
using BDProjeto.Aplicacao;
using Aplicacao;
using BDProjeto.RepositorioADO;

namespace DOS
{
    class Program
    {
        static void Main(string[] args)
        {
            bd banco = new bd();
            UsuarioAplicacao usuarioAplicacao = UsuarioAplicacaoConstrutor.usuarioApADO();

            ////ATUALIZANDO VALORES DA TABELA
            //string strQueryUpdate = "UPDATE usuarios SET nome='Fabio' WHERE usuarioId=1 ";
            //bd.ExecutaComando(strQueryUpdate);


            ////DELETANDO VALORES DA TABELA
            //string strQueryDelete = "DELETE FROM usuarios WHERE usuarioId= 1 ";
            //bd.ExecutaComando(strQueryDelete);

            Console.Write("Digite o nome do usuário: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o nome do cargo: ");
            string cargo = Console.ReadLine();

            Console.Write("Digite a data do usuário: ");
            string date = Console.ReadLine();

            //////INSERINDO VALORES DA TABELA
            ////string strQueryInsert = string.Format("INSERT INTO usuarios(nome, cargo, date) VALUES('{0}', '{1}', '{2}') ",nome, cargo, date);//Fomata os parametros para string 
            ////bd.ExecutaComando(strQueryInsert);

            var usuarios = new Usuarios
            {
                Nome = nome,
                Cargo = cargo,
                Data = Convert.ToDateTime(date)

            };

            ////usuarios.Id = 2004;
            usuarioAplicacao.Salvar(usuarios);
            //usuarioAplicacao.Excluir(2006);

            //BUSCANDO TODOS OS USUARIOS DA TABELA USUARIO

            //EXECUTOR DE DADOS
            var  dados = usuarioAplicacao.ListarUsuarios(usuarios);


            foreach (var usuario in dados)
            {
                Console.WriteLine("Id:{0}, Nome:{1}, Cargo:{2}, Data:{3}", usuario.Id, usuario.Nome, usuario.Cargo, usuario.Data);
            }
            {
                //EXIBINDO OS DADOS DA TABELA
                //Console.WriteLine("Id:{0}, Nome:{1}, Cargo:{2}, Data:{3}", dados["usuarioId"], dados["nome"], dados["cargo"], dados["date"]);

            }





        }
    }
}
