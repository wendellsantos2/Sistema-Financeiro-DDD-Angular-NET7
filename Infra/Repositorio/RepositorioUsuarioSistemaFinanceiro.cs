
using Domain.Interface.Generics;
using Domain.Interface.InterfaceServicos;
using Domain.Interface.IUsuarioSistemaFinanceiro;
using Entities.Entidades;
using Infra.Repositorio.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositorio
{
    public class RepositorioUsuarioSistemaFinanceiro : RepositoryGenerics<UsuarioSistemaFinanceiro>, InterfaceUsuarioSistemaFinanceiro
    {
        public Task Add(SistemaFinanceiro objeto)
        {
            throw new NotImplementedException();
        }

        public Task Delete(SistemaFinanceiro objeto)
        {
            throw new NotImplementedException();
        }

        public Task<IList<UsuarioSistemaFinanceiro>> ListarUsuariosSistema(int IdSistema)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioSistemaFinanceiro> ObterUsuarioPorEmail(string emailUsuario)
        {
            throw new NotImplementedException();
        }

        public Task RemoveUsuarios(List<UsuarioSistemaFinanceiro> usuarios)
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
