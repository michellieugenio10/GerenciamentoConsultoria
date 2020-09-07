using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoConsultoria.DAL.Interfaces
{
    public interface IConnectionFactoryDAL
    {
        Task<DbConnection> ConexaoGerenciamentoConsultorio();
    }
}
