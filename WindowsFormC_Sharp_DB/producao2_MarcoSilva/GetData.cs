using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace producao2_MarcoSilva
{
    class GetData
    {
        public DataTable BuscaDados(string stringConnection, string SSQL)
        {
            //conecta à base de dados
            SqlConnection C = new SqlConnection(stringConnection);
            C.Open();

            //cria o comando sql necessários para extrair os dados requeridos:
            SqlCommand command = C.CreateCommand();
            command.CommandText = SSQL;

            //obtem os dados para inserir na tabela 
            SqlDataAdapter da = new SqlDataAdapter(command);
            var dt = new DataTable();
            da.Fill(dt);

            //desliga a conexão após passar os dados
            C.Close();

            return dt;
        }
    }
}
