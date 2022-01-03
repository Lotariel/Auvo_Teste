<%@ Page Title="" Language="C#" MasterPageFile="~/Visao/MasterPage.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="AUvo_Teste.Visao.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style13 {
        width: 100%;
        height: 115px;
    }
    .auto-style14 {
        height: 34px;
    }
    .auto-style18 {
        width: 100%;
        height: 105px;
    }
    .auto-style19 {
        height: 38px;
    }
    .auto-style20 {
        height: 38px;
        width: 145px;
    }
    .auto-style22 {
        height: 38px;
        width: 187px;
    }
    .auto-style26 {
        width: 187px;
    }
    .auto-style27 {
        width: 145px;
    }
    .auto-style28 {
        width: 98%;
        height: 115px;
    }
    .auto-style29 {
        height: 38px;
        width: 158px;
    }
    .auto-style30 {
        width: 158px;
    }
    .auto-style31 {
        height: 38px;
        width: 177px;
    }
    .auto-style32 {
        width: 177px;
    }
    .auto-style33 {
        height: 22px;
    }
    .auto-style34 {
        height: 20px;
    }
    .auto-style35 {
        height: 23px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style13">
        <tr>
            <td class="auto-style14" colspan="2" style="text-align: center">
                <asp:Label ID="lbl_erro" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style14">
                <table class="auto-style28">
                    <tr>
                        <td class="auto-style14" style="border: thin solid #337AB7; background-color: #337AB7; color: #FFFFFF;">
                            <asp:Label ID="Label4" runat="server" Text="Cidades mais quentes hoje"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="border: thin solid #337AB7">
                            <table style="width:100%;">
                                <tr>
                                    <td>
                                        <asp:Label ID="lbl_cidade_01_max" runat="server" Text="Label"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbl_min01" runat="server" Text="Label"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbl_max01" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lbl_cidade_02_max" runat="server" Text="Label"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbl_min02" runat="server" Text="Label"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbl_max02" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style33">
                                        <asp:Label ID="lbl_cidade_03_max" runat="server" Text="Label"></asp:Label>
                                    </td>
                                    <td class="auto-style33">
                                        <asp:Label ID="lbl_min03" runat="server" Text="Label"></asp:Label>
                                    </td>
                                    <td class="auto-style33">
                                        <asp:Label ID="lbl_max03" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
            <td class="auto-style14">
                <table class="auto-style13">
                    <tr>
                        <td class="auto-style14" style="background-color: #337AB7; color: #FFFFFF">
                            <asp:Label ID="Label5" runat="server" Text="Cidades mais frias hoje"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="border: thin solid #337AB7">
                            <table style="width:100%;">
                                <tr>
                                    <td class="auto-style34">
                                        <asp:Label ID="lbl_cidade_01_max0" runat="server" Text="Label"></asp:Label>
                                    </td>
                                    <td class="auto-style34">
                                        <asp:Label ID="lbl_min4" runat="server" Text="Label"></asp:Label>
                                    </td>
                                    <td class="auto-style34">
                                        <asp:Label ID="lbl_max4" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lbl_cidade_02_max0" runat="server" Text="Label"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbl_min5" runat="server" Text="Label"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbl_max5" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style33">
                                        <asp:Label ID="lbl_cidade_03_max0" runat="server" Text="Label"></asp:Label>
                                    </td>
                                    <td class="auto-style33">
                                        <asp:Label ID="lbl_min6" runat="server" Text="Label"></asp:Label>
                                    </td>
                                    <td class="auto-style33">
                                        <asp:Label ID="lbl_max6" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td class="auto-style14" colspan="2" style="text-align: center">
                <asp:Label ID="Label16" runat="server" Font-Bold="True" Text="Cidade:"></asp:Label>
                <br />
                <asp:DropDownList ID="DDL_cidade" runat="server" AutoPostBack="True" OnTextChanged="DDL_cidade_TextChanged">
                </asp:DropDownList>
                <br />
                <br />
                <asp:Label ID="Label17" runat="server" Font-Size="XX-Large" Text="Clima para os próximos sete dias na cidade de "></asp:Label>
&nbsp;<asp:Label ID="lbl_nome_cidade" runat="server" Font-Size="XX-Large"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style14" colspan="2">
                <table class="auto-style18">
                    <tr>
                        <td class="auto-style20" style="background-color: #337AB7; color: #FFFFFF; text-align: center;">
                            <asp:Label ID="Label9" runat="server" Text="Segunda-Feira"></asp:Label>
                        </td>
                        <td class="auto-style22" style="background-color: #337AB7; color: #FFFFFF; text-align: center;">
                            <asp:Label ID="Label10" runat="server" Text="Terça- Feira"></asp:Label>
                        </td>
                        <td class="auto-style29" style="background-color: #337AB7; color: #FFFFFF; text-align: center;">
                            <asp:Label ID="Label11" runat="server" Text="Quarta-Feira"></asp:Label>
                        </td>
                        <td class="auto-style29" style="background-color: #337AB7; color: #FFFFFF; text-align: center;">
                            <asp:Label ID="Label12" runat="server" Text="Quinta-Feira"></asp:Label>
                        </td>
                        <td class="auto-style31" style="background-color: #337AB7; color: #FFFFFF; text-align: center;">
                            <asp:Label ID="Label13" runat="server" Text="Sexta-Feira"></asp:Label>
                        </td>
                        <td class="auto-style19" style="background-color: #337AB7; color: #FFFFFF; text-align: center;">
                            <asp:Label ID="Label14" runat="server" Text="Sabado"></asp:Label>
                        </td>
                        <td class="auto-style19" style="background-color: #337AB7; color: #FFFFFF; text-align: center;">
                            <asp:Label ID="Label15" runat="server" Text="Domingo"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style27">
                            <table style="width:100%;">
                                <tr>
                                    <td class="auto-style35">
                                        <asp:Label ID="maxima" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="minima" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="clima" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </td>
                        <td class="auto-style26">
                            <table style="width:100%;">
                                <tr>
                                    <td class="auto-style35">
                                        <asp:Label ID="maxima0" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="minima0" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="clima0" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </td>
                        <td class="auto-style30">
                            <table style="width:100%;">
                                <tr>
                                    <td class="auto-style35">
                                        <asp:Label ID="maxima1" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="minima1" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="clima1" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </td>
                        <td class="auto-style30">
                            <table style="width:100%;">
                                <tr>
                                    <td class="auto-style35">
                                        <asp:Label ID="maxima2" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="minima2" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="clima2" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </td>
                        <td class="auto-style32">
                            <table style="width:100%;">
                                <tr>
                                    <td class="auto-style35">
                                        <asp:Label ID="maxima3" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="minima3" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="clima3" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </td>
                        <td>
                            <table style="width:100%;">
                                <tr>
                                    <td class="auto-style35">
                                        <asp:Label ID="maxima4" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="minima4" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="clima4" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </td>
                        <td>
                            <table style="width:100%;">
                                <tr>
                                    <td class="auto-style35">
                                        <asp:Label ID="maxima5" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="minima5" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="clima5" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
