<%@ Page Title="" Language="C#" MasterPageFile="~/Visao/MasterPage.Master" AutoEventWireup="true" CodeBehind="Sobre.aspx.cs" Inherits="AUvo_Teste.Visao.Sobre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style6 {
            width: 100%;
            height: 391px;
        }
        .auto-style7 {
            width: 188px;
        }
        .auto-style8 {
            width: 188px;
            height: 184px;
        }
        .auto-style9 {
            height: 184px;
        }
 p.MsoNormal
	{margin-top:0cm;
	margin-right:0cm;
	margin-bottom:8.0pt;
	margin-left:0cm;
	line-height:107%;
	font-size:11.0pt;
	font-family:"Calibri",sans-serif;
	}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style6">
        <tr>
            <td class="auto-style8">
                <asp:Image ID="Image2" runat="server" BorderColor="Black" BorderWidth="2px" Height="178px" ImageUrl="~/Imagem/18671679_10209624082826935_444121842664797488_o.jpg" Width="184px" />
            </td>
            <td class="auto-style9">
                <asp:Label ID="Label2" runat="server" Text="Nome: Guilherme William"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label3" runat="server" Text="Nascido em: Campinas"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label4" runat="server" Text="Reside atualmente em: Sumaré"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label5" runat="server" Text="Titulo: Desenvolvedor C#"></asp:Label>
&nbsp;JUNIOR</td>
        </tr>
        <tr>
            <td class="auto-style7" style="vertical-align: top; font-family: Arial, Helvetica, sans-serif;">OBJETIVOS:<br />
                Conseguir atuar como desenvolvedor de sistemas em uma local bacana de trabalhar.</td>
            <td style="vertical-align: top; font-family: Arial, Helvetica, sans-serif;">Sobre o Guilherme:<br />
                <p class="MsoNormal">
                    Um homem entusiasta com a Linguagem C#, adora desenvolver como Back-End porém precisa aprimorar um pouco mais o seu Front-End. Possui conhecimento com SQL e programas para consumir API’s. <o:p></o:p>
                </p>
                <p class="MsoNormal">
                    Já realizou projetos de integrações via API com empresas como PagBem, Jadlog e Arquivei. É formado em análises de sistema pela faculdade UNIP.<o:p></o:p></p>
                <p class="MsoNormal">
                    <o:p>Começou na área de programação recentemente e esta em busca de oportuinidades para ficar cada vez melhor como profissional.</o:p></p>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td>Linkedin: https://www.linkedin.com/in/guilherme-william-23208233/</td>
        </tr>
    </table>
</asp:Content>
