using Domain.Interface.Generics;
using Domain.Interface.ICategoria;
using Entities.Entidades;
using Infra.Configuracao;
using Infra.Repositorio.Generics;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositorio
{
    public class RepositorioCategoria : RepositoryGenerics<Categoria>, InterfaceCategoria
    {
        private readonly DbContextOptions<ContextBase> _OptionsBuilder;

        public RepositorioCategoria()
        {
            _OptionsBuilder = new DbContextOptions<ContextBase>();
        }

        public Task Add(SistemaFinanceiro objeto)
        {
            throw new NotImplementedException();
        }

        public Task Delete(SistemaFinanceiro objeto)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Categoria>> ListarCategoriasUsuario(string emailUsuario)
        {
            using (var banco = new ContextBase(_OptionsBuilder))
            {
                return await
                    (from s in banco.SistemaFinanceiro
                     join c in banco.Categoria on s.Id equals c.IdSistema
                     join us in banco.UsuarioSistemaFinanceiro on s.Id equals us.IdSistema
                     where us.EmailUsuario.Equals(emailUsuario) && us.SistemaAtual
                     select c).AsNoTracking().ToListAsync();
            }
        }

        public Task<IList<Categoria>> ListarCategoriaUsuario(string emailUsuario)
        {
            throw new NotImplementedException();
        }

        public Task Update(SistemaFinanceiro objeto)
        {
            throw new NotImplementedException();
        }

        Task<SistemaFinanceiro> InterfaceGeneric<SistemaFinanceiro>.GetEntityById(int Id)
        {
            throw new NotImplementedException();
        }

        Task<List<SistemaFinanceiro>> InterfaceGeneric<SistemaFinanceiro>.List()
        {
            throw new NotImplementedException();
        }
    }
}