using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AUvo_Teste.DAO;
using AUvo_Teste.Modelo;

namespace AUvo_Teste.Controle
{
    public class Estado_Controle
    {

        private Estado_Modelo estado_Modelo;
        private List<Estado_Modelo> estados_Modelos = new List<Estado_Modelo>();
        public List<Estado_Modelo> Carregar_Modelo_Estado()
        {
            try
            {
                var EstadoDados = new ContextClimaTempoSimples().Estado.ToList();
                int Contador = EstadoDados.Count;


                for (int i = 0; i < Contador; i++)
                {
                    estado_Modelo = new Estado_Modelo()
                    {
                        ID = EstadoDados[i].Id,
                        Nome = EstadoDados[i].Nome,
                        UF = EstadoDados[i].UF
                    };

                    estados_Modelos.Add(estado_Modelo);
                }
                return estados_Modelos;
            }
            catch (Exception ex)
            {
                throw new Exception("[Controle.Carregar_Modelo_Estado]:" + ex.Message);
            }
        }
    }
}