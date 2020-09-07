using GerenciamentoConsultoria.DAL.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoConsultoria.DAL
{
    public class ConnectionFactoryDAL : IConnectionFactoryDAL
    {
        private readonly IConfiguration _configuration;
        public async Task<DbConnection> ConexaoGerenciamentoConsultorio()
        {
            var conexao = new SqlConnection(_configuration.GetSection("ConnectionString:GerenciamentoConsultoria").Value);

            await conexao.OpenAsync();

            return conexao;
        }
        public ConnectionFactoryDAL(IConfiguration configuration)
        {
            _configuration = configuration;
        }
    }
}
