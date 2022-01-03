using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AUvo_Teste.DAO;
using AUvo_Teste.Modelo;

namespace AUvo_Teste.Controle
{
    public class PrevisaoClima_Controle
    {
        private List<PrevisaoClima_Modelo> previsaoClimas_Modelos = new List<PrevisaoClima_Modelo>();
        private PrevisaoClima_Modelo previsaoClima_Modelo = new PrevisaoClima_Modelo();

        public List<PrevisaoClima_Modelo> Carregar_Modelo_PrevisaoClima()
        {
            try
            {
                var PrevisaoClimaDados = new ContextClimaTempoSimples().PrevisaoClima.ToList();
                int Contador = PrevisaoClimaDados.Count;

                for (int i = 0; i < Contador; i++)
                {
                    previsaoClima_Modelo = new PrevisaoClima_Modelo()
                    {
                        ID = PrevisaoClimaDados[i].Id,
                        CidadeID = PrevisaoClimaDados[i].CidadeId,
                        Clima = PrevisaoClimaDados[i].Clima,
                        DataPrevisao = PrevisaoClimaDados[i].DataPrevisao,
                        TemperaturaMaxima = Convert.ToDecimal(PrevisaoClimaDados[i].TemperaturaMaxima),
                        TemperaturaMinima = Convert.ToDecimal(PrevisaoClimaDados[i].TemperaturaMinima)
                    };

                    previsaoClimas_Modelos.Add(previsaoClima_Modelo);
                }
                return previsaoClimas_Modelos;
            }
            catch (Exception ex)
            {
                throw new Exception("[Controle.Carregar_Modelo_PrevisaoClima]: " + ex.Message);
            }
        }

        public bool Gravar_Tabela_PrevisaoClima(PrevisaoClima_Modelo previsao)
        {
            try
            {
                bool Ok = false;
                var context = new ContextClimaTempoSimples();
                context.PrevisaoClima.Add(new PrevisaoClima()
                {
                    CidadeId = previsao.CidadeID,
                    Clima = previsao.Clima,
                    Id = previsao.ID,
                    DataPrevisao = previsao.DataPrevisao,
                    TemperaturaMaxima = previsao.TemperaturaMaxima,
                    TemperaturaMinima = previsao.TemperaturaMinima
                });
                context.SaveChanges();

                Ok = true;
                return Ok;
            }
            catch (Exception ex)
            {
                throw new Exception("[Controle.Gravar_Tabela_PrevisaoClima]: " + ex.Message);
            }
        }
    }
}