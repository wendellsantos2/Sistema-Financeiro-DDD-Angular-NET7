﻿using Domain.Interface.Generics;
using Entities.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface.ISistemaFinanceiro
{
    public interface InterfaceSistemaFinanceiro : InterfaceGeneric<SistemaFinanceiro>
    {

        Task<IList<SistemaFinanceiro>> ListaSistemasUsuario(string emailUsuario);
    }
}
