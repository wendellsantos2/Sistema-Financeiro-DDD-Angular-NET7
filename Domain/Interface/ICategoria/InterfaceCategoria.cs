
using Domain.Interface.Generics;
using Entities.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface.ICategoria
{
    public interface InterfaceCategoria : InterfaceGeneric<SistemaFinanceiro>
    {
        Task<IList<Categoria>> ListarCategoriaUsuario(string emailUsuario);
    }
}
