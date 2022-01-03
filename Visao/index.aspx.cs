using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AUvo_Teste.Controle;
using AUvo_Teste.Modelo;


namespace AUvo_Teste.Visao
{
    public partial class index : System.Web.UI.Page
    {

        private Estado_Controle estado_Controle = new Estado_Controle();
        private List<Estado_Modelo> estado_Modelo = new List<Estado_Modelo>();
        private Cidade_Controle cidade_Controle = new Cidade_Controle();
        private List<Cidade_Modelo> cidades_modelos = new List<Cidade_Modelo>();
        private PrevisaoClima_Controle previsaoClima_Controle = new PrevisaoClima_Controle();
        private List<PrevisaoClima_Modelo> previsaoClimas_Modelos = new List<PrevisaoClima_Modelo>();
        protected void Page_Load(object sender, EventArgs e)
        {
            Carregar_Tela();
        }

        #region Eventos
        protected void DDL_cidade_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lbl_nome_cidade.Text = DDL_cidade.SelectedItem.Text;
                Exibir_Clima_Semana(DDL_cidade.SelectedItem.Text);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        #endregion

        #region Funções e Métodos
        private void Carregar_Tela()
        {
            try
            {
                lbl_erro.Text = "";
                Carregar_Estado();
                Carregar_Cidade();
                Carregar_PrevisaoClima();
                Carregar_ComboBox();
                Exibir_Cidades_Quentes();
                Exibir_Cidades_Frias();
            }
            catch (Exception ex)
            {
                lbl_erro.Text = "Erro ao Carregar tela.\nMotivo:" + ex.Message;
            }
        }
        private List<Estado_Modelo> Carregar_Estado()
        {
            try
            {
                return estado_Modelo = estado_Controle.Carregar_Modelo_Estado();
            }
            catch (Exception ex)
            {
                lbl_erro.Text = "Erro ao Carregar modelo Estado.\nMotivo:" + ex.Message;
                return estado_Modelo;
            }
        }
        private List<Cidade_Modelo> Carregar_Cidade()
        {
            try
            {
                return cidades_modelos = cidade_Controle.Carregar_Modelo_Cidade();
            }
            catch (Exception ex)
            {
                lbl_erro.Text = "Erro ao Carregar modelo Cidade.\nMotivo:" + ex.Message;
                return cidades_modelos;
            }
        }
        private List<PrevisaoClima_Modelo> Carregar_PrevisaoClima()
        {
            try
            {
                return previsaoClimas_Modelos = previsaoClima_Controle.Carregar_Modelo_PrevisaoClima();
            }
            catch (Exception ex)
            {
                lbl_erro.Text = "Erro ao Carregar modelo Previsão Clima.\nMotivo:" + ex.Message;
                return previsaoClimas_Modelos;
            }
        }
        private void Inserir_Dados_Em_Tabela_PrevisaoClima()
        {
            try
            {
                PrevisaoClima_Modelo modelo_previsao = new PrevisaoClima_Modelo();
                Random random = new Random();

                for (int i = 1; i < 21; i++)
                {
                    modelo_previsao.CidadeID = random.Next(1, 3);
                    modelo_previsao.Clima = Gerar_Clima(random.Next(1, 7));
                    modelo_previsao.DataPrevisao = DateTime.Now;
                    modelo_previsao.TemperaturaMaxima = random.Next(22, 36);
                    modelo_previsao.TemperaturaMinima = random.Next(10, 21);
                    previsaoClima_Controle.Gravar_Tabela_PrevisaoClima(modelo_previsao);
                }
                lbl_erro.Text = "Dados salvos com sucesso";

            }
            catch (Exception ex)
            {
                lbl_erro.Text = "Erro ao gravas dados na tabela Previsao Clima.\nMotivo:" + ex.Message;
                throw;
            }
        }
        private string Gerar_Clima(int valor)
        {
            try
            {
                switch (valor)
                {
                    case 1:
                        return "Ensolarado";
                    case 2:
                        return "Tempestuoso";
                    case 3:
                        return "Chuva";
                    case 4:
                        return "Ventania";
                    case 5:
                        return "Neblima";
                    case 6:
                        return "Vento Frio";
                    default:
                        return "Tropical";

                }
            }
            catch (Exception ex)
            {
                lbl_erro.Text = "Erro ao gerar clima.\nMotivo:" + ex.Message;
                throw;
            }
        }
        private void Carregar_ComboBox()
        {
            try
            {
                if (String.IsNullOrEmpty(DDL_cidade.Text))
                {
                    for (int i = 0; i < cidades_modelos.Count; i++)
                    {
                        DDL_cidade.Items.Add(cidades_modelos[i].Nome);
                    }
                    lbl_nome_cidade.Text = DDL_cidade.SelectedItem.Text;
                }


            }
            catch (Exception ex)
            {

                throw;
            }
        }
        private void Exibir_Cidades_Quentes()
        {
            try
            {
                lbl_cidade_01_max.Text = cidades_modelos[1].Nome + "/" + estado_Modelo[24].UF;
                lbl_cidade_02_max.Text = cidades_modelos[0].Nome + "/" + estado_Modelo[24].UF;
                lbl_cidade_03_max.Text = cidades_modelos[2].Nome + "/" + estado_Modelo[24].UF;

                lbl_min01.Text = "Min " + Convert.ToInt32(previsaoClimas_Modelos[1].TemperaturaMinima) + " ºC";
                lbl_min02.Text = "Min " + Convert.ToInt32(previsaoClimas_Modelos[0].TemperaturaMinima) + " ºC";
                lbl_min03.Text = "Min " + Convert.ToInt32(previsaoClimas_Modelos[2].TemperaturaMinima) + " ºC";

                lbl_max01.Text = "Máx " + Convert.ToInt32(previsaoClimas_Modelos[1].TemperaturaMaxima) + " ºC";
                lbl_max02.Text = "Máx " + Convert.ToInt32(previsaoClimas_Modelos[0].TemperaturaMaxima) + " ºC";
                lbl_max03.Text = "Máx " + Convert.ToInt32(previsaoClimas_Modelos[2].TemperaturaMaxima) + " ºC";

            }
            catch (Exception ex)
            {

                throw;
            }
        }
        private void Exibir_Cidades_Frias()
        {
            try
            {
                lbl_cidade_01_max0.Text = cidades_modelos[1].Nome + "/" + estado_Modelo[24].UF;
                lbl_cidade_02_max0.Text = cidades_modelos[0].Nome + "/" + estado_Modelo[24].UF;
                lbl_cidade_03_max0.Text = cidades_modelos[2].Nome + "/" + estado_Modelo[24].UF;

                lbl_min4.Text = "Min " + Convert.ToInt32(previsaoClimas_Modelos[1].TemperaturaMinima) + " ºC";
                lbl_min5.Text = "Min " + Convert.ToInt32(previsaoClimas_Modelos[0].TemperaturaMinima) + " ºC";
                lbl_min6.Text = "Min " + Convert.ToInt32(previsaoClimas_Modelos[2].TemperaturaMinima) + " ºC";

                lbl_max4.Text = "Máx " + Convert.ToInt32(previsaoClimas_Modelos[1].TemperaturaMaxima) + " ºC";
                lbl_max5.Text = "Máx " + Convert.ToInt32(previsaoClimas_Modelos[0].TemperaturaMaxima) + " ºC";
                lbl_max6.Text = "Máx " + Convert.ToInt32(previsaoClimas_Modelos[2].TemperaturaMaxima) + " ºC";

            }
            catch (Exception ex)
            {

                throw;
            }
        }
        private void Exibir_Clima_Semana(string NomeCidade)
        {
            try
            {
                int i = 0;
                switch (NomeCidade)
                {
                    case "Sumaré":
                        i = 1;
                        break;
                    case "Hortolandia":
                        i = 2;
                        break;                    
                    default:
                        i = 0;
                        break;
                }

                maxima.Text = "Máx " + Convert.ToInt32(previsaoClimas_Modelos[i].TemperaturaMaxima) + " ºC";
                maxima0.Text = "Máx " + Convert.ToInt32(previsaoClimas_Modelos[i].TemperaturaMaxima) + " ºC";
                maxima1.Text = "Máx " + Convert.ToInt32(previsaoClimas_Modelos[i].TemperaturaMaxima) + " ºC";
                maxima2.Text = "Máx " + Convert.ToInt32(previsaoClimas_Modelos[i].TemperaturaMaxima) + " ºC";
                maxima2.Text = "Máx " + Convert.ToInt32(previsaoClimas_Modelos[i].TemperaturaMaxima) + " ºC";
                maxima3.Text = "Máx " + Convert.ToInt32(previsaoClimas_Modelos[i].TemperaturaMaxima) + " ºC";
                maxima4.Text = "Máx " + Convert.ToInt32(previsaoClimas_Modelos[i].TemperaturaMaxima) + " ºC";
                maxima5.Text = "Máx " + Convert.ToInt32(previsaoClimas_Modelos[i].TemperaturaMaxima) + " ºC";

                minima.Text = "Min " + Convert.ToInt32(previsaoClimas_Modelos[i].TemperaturaMinima) + " ºC";
                minima0.Text = "Min " + Convert.ToInt32(previsaoClimas_Modelos[i].TemperaturaMinima) + " ºC";
                minima1.Text = "Min " + Convert.ToInt32(previsaoClimas_Modelos[i].TemperaturaMinima) + " ºC";
                minima2.Text = "Min " + Convert.ToInt32(previsaoClimas_Modelos[i].TemperaturaMinima) + " ºC";
                minima3.Text = "Min " + Convert.ToInt32(previsaoClimas_Modelos[i].TemperaturaMinima) + " ºC";
                minima4.Text = "Min " + Convert.ToInt32(previsaoClimas_Modelos[i].TemperaturaMinima) + " ºC";
                minima5.Text = "Min " + Convert.ToInt32(previsaoClimas_Modelos[i].TemperaturaMinima) + " ºC";

                clima.Text = previsaoClimas_Modelos[i].Clima;
                clima0.Text = previsaoClimas_Modelos[i].Clima;
                clima1.Text = previsaoClimas_Modelos[i].Clima;
                clima2.Text = previsaoClimas_Modelos[i].Clima;
                clima3.Text = previsaoClimas_Modelos[i].Clima;
                clima4.Text = previsaoClimas_Modelos[i].Clima;
                clima5.Text = previsaoClimas_Modelos[i].Clima;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        #endregion

        

    }
}