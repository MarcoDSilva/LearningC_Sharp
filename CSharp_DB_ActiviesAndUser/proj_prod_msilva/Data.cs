using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace proj_prod_msilva
{
    class Data
    {
        public DataTable GetData(string SSQL)
        {
            //cria a conexão À base
            SqlConnection connection = new SqlConnection(StringConnection.SC);
            connection.Open();

            //cria o comando SQL necessário para extrair dados requeridos:
            SqlCommand command = connection.CreateCommand();
            command.CommandText = SSQL;

            //obtem dados da tabela especificada para uma tabela em memória
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            var table = new DataTable();
            adapter.Fill(table);

            //desligar a conexão com a base de dados
            connection.Close();
            return table;
        }

        public void AddData(string name, int year, string gender)
        {
            string query = "INSERT into Pessoas(nome,ano_nascimento,sexo) " +
                            $"values(@name, @bday, @gender)";

            SqlCommand commandInsert;
            SqlConnection insertData = new SqlConnection(StringConnection.SC);

            insertData.Open();
            commandInsert = new SqlCommand(query,insertData);

            commandInsert.Parameters.AddWithValue("@name", name);
            commandInsert.Parameters.AddWithValue("@bday", year);
            commandInsert.Parameters.AddWithValue("@gender", gender);

            commandInsert.ExecuteNonQuery();
            insertData.Close();
        }

        public void AddActivityRegisterData(int user, string activity, string quote)
        {
            string query = "INSERT into Registos_Associacao(pessoa, quota, actividade) " +
                           $"values(@person, @quote, @activity)";

            SqlCommand commandInsert;
            SqlConnection insertData = new SqlConnection(StringConnection.SC);

            insertData.Open();
            commandInsert = new SqlCommand(query, insertData);

            commandInsert.Parameters.AddWithValue("@person", user);
            commandInsert.Parameters.AddWithValue("@activity", activity);
            commandInsert.Parameters.AddWithValue("@quote", quote);

            commandInsert.ExecuteNonQuery();
            insertData.Close();
        }

        public void AddNewActivity(string id, string designation)
        {
            string query = "INSERT into Actividades(id, designacao) " +
                           $"values(@id, @designacao)";

            SqlCommand commandInsert;
            SqlConnection insertData = new SqlConnection(StringConnection.SC);

            insertData.Open();
            commandInsert = new SqlCommand(query, insertData);

            commandInsert.Parameters.AddWithValue("@id", id);
            commandInsert.Parameters.AddWithValue("@designacao", designation);

            commandInsert.ExecuteNonQuery();
            insertData.Close();
        }

        public void UpdateActivityInfo(string id, string designacao)
        {
            string query = $"UPDATE Actividades SET designacao = '{designacao}'" +
                $" WHERE id = '{id}'";

            SqlConnection connection = new SqlConnection(StringConnection.SC);
            connection.Open();

            SqlCommand actualization = new SqlCommand(query, connection);
            actualization.ExecuteNonQuery();

            connection.Close();
        }

        public void UpdatePersonInfo(int id, string name, int bday, string gender)
        {
            string query = $"UPDATE Pessoas SET nome = '{name}', ano_nascimento = {bday}," +
                $" sexo = '{gender}'" +
                $" WHERE id = '{id}'";

            SqlConnection connection = new SqlConnection(StringConnection.SC);
            connection.Open();

            SqlCommand actualization = new SqlCommand(query, connection);
            actualization.ExecuteNonQuery();

            connection.Close();
        }

        public void FillCombo(ComboBox box, string query, string name_col)
        {
            box.DataSource = this.GetData(query);
            box.DisplayMember = name_col;
            box.ValueMember = "id";
        }
    }
}
