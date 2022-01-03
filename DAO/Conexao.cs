using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace AUvo_Teste.DAO
{
    public class Conexao
    {
        public SqlConnection ConectaraoBanco()
        {

            SqlConnection con = new SqlConnection(@"Data Source=LOTARIEL_MACHIN\LOTARIEL;Password=Lotariel;User ID=sa;Initial Catalog=ClimaTempoSimples;Min Pool Size=5;Max Pool Size=10000;Connect Timeout=100");
            con.Open();
            return con;
        }

        public SqlConnection FecharConexao()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.\LOTARIEL;Password=Lotariel;User ID=sa;Initial Catalog=ClimaTempoSimples;";
            con.Close();
            return con;
        }
    }
}