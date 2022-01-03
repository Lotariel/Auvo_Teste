using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AUvo_Teste.DAO;
using AUvo_Teste.Modelo;

namespace AUvo_Teste.Controle
{
    public class Cidade_Controle
    {
        private List<Cidade_Modelo> cidade_Modelos = new List<Cidade_Modelo>();
        private Cidade_Modelo cidade_Modelo = new Cidade_Modelo();
        
        public List<Cidade_Modelo> Carregar_Modelo_Cidade()
        {
            try
            {
                var CidadeDados = new ContextClimaTempoSimples().Cidade.ToList();
                int Contador = CidadeDados.Count;

                for (int i = 0; i < Contador; i++)
                {
                    cidade_Modelo = new Cidade_Modelo()
                    {
                        ID = CidadeDados[i].Id,
                        Nome = CidadeDados[i].Nome,
                        EstadoID = CidadeDados[i].EstadoId
                    };
                    cidade_Modelos.Add(cidade_Modelo);
                }
                                        
                    
                
                return cidade_Modelos;
            }
            catch (Exception ex)
            {

                throw new Exception("[Controle.Carregar_Modelo_Cidade]: "+ ex.Message);
            }
        }
        
    }
}