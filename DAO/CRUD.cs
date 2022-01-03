using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using AUvo_Teste.Modelo;
using System.Data;

namespace AUvo_Teste.DAO
{
    public class CRUD : Conexao
    {

        private Maxima_e_Minima_Modelo modelo = new Maxima_e_Minima_Modelo();
        private string Script = "";

        public void Consultar_Valores_Maxima()
        {
            try
            {
                Script = @"select (Cidade.Nome + '/' + Estado.UF) AS Nome,PrevisaoClima.TemperaturaMinima ,PrevisaoClima.TemperaturaMaxima from Cidade 
INNER JOIN Estado ON Cidade.EstadoId = Estado.Id
INNER JOIN PrevisaoClima on PrevisaoClima.CidadeId = Cidade.Id order by PrevisaoClima.TemperaturaMaxima DESC";

                SqlCommand select = new SqlCommand(Script, ConectaraoBanco());

                FecharConexao();
                select.ExecuteReader();               

            }

            catch (Exception)
            {

                throw;
            }
        }


        //Função adquirida da internet
        public DataTable ObterTabela(SqlDataReader reader)
        {//Código adiquirido do site https://www.devmedia.com.br/obtendo-um-datatable-a-partir-de-um-datareader-em-net-em-csharp-e-vb-net/25738

            DataTable tbEsquema = reader.GetSchemaTable();
            DataTable tbRetorno = new DataTable();

            foreach (DataRow r in tbEsquema.Rows)
            {
                if (!tbRetorno.Columns.Contains(r["ColumnName"].ToString()))
                {
                    DataColumn col = new DataColumn()
                    {
                        ColumnName = r["ColumnName"].ToString(),
                        Unique = Convert.ToBoolean(r["IsUnique"]),
                        AllowDBNull = Convert.ToBoolean(r["AllowDBNull"]),
                        ReadOnly = Convert.ToBoolean(r["IsReadOnly"])
                    };
                    tbRetorno.Columns.Add(col);
                }
            }

            while (reader.Read())
            {
                DataRow novaLinha = tbRetorno.NewRow();
                for (int i = 0; i < tbRetorno.Columns.Count; i++)
                {
                    novaLinha[i] = reader.GetValue(i);
                }
                tbRetorno.Rows.Add(novaLinha);
            }

            return tbRetorno;
        }
    }
}