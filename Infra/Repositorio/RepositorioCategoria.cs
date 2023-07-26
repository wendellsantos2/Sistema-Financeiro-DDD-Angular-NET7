


using Domain.Interface.ICategoria;
using Entities.Entidades;
using Infra.Configuracao;
using Infra.Repositorio.Generics;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositorio
{
    public class RepositorioCategoria : RepositoryGenerics<SistemaFinanceiro>, InterfaceCategoria
    {
        private readonly DbContextOptions<ContextBase> _OptionsBuilder;
        public RepositorioCategoria()
        {

        }


        public async Task<IList<Categoria>> ListarCategoriaUsuario(string emailUsuario)
        {
           using(var banco = new ContextBase(_OptionsBuilder))
            {
                return await
                    (from s in banco.SistemaFinaceiro
                     join c in banco.Categoria on s.Id equals c.IdSistema
                     join us in banco.UsuarioSistemaFinanceiro on s.Id equals us.IdSistema
                     where us.EmailUsuario.Equals(emailUsuario) && us.SistemaAtual
                     select c).AsNoTracking().ToListAsync();
                    
            }
        }
    }
}
