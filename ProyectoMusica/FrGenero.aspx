<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="FrGenero.aspx.cs" Inherits="FrGenero" Title="P疊ina sin t咜ulo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style3
        {
            width: 120px;
        }
        .style7
        {
            width: 201px;
        }
        .style8
        {
            width: 43px;
        }
        .style9
        {
            width: 57px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="cphContenido" Runat="Server">
    <table class="style1" style="height: 255px; width: 98%">
        <tr>
            <td class="style8">
                <asp:Button ID="btAtrasGe" runat="server" onclick="btAtrasGe_Click" 
                    Text="&lt;-Atras" />
            </td>
            <td class="style7">
                Genero :
                <asp:TextBox ID="txGenero" runat="server"></asp:TextBox>
            </td>
            <td class="style3">
               
                <asp:Button ID="btBuscarGe" runat="server" Text="Buscar" />
               
            </td>
            <td class="style9">
                <asp:Button ID="btCerrarGe" runat="server" onclick="btCerrarGe_Click" 
                    Text="Cerrar" />
            </td>
        </tr>
        <tr>
            <td class="style8">
                &nbsp;</td>
            <td class="style7">
                <asp:GridView ID="grGeneros" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="id" HeaderText="Id" />
                        <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                        <asp:BoundField DataField="idArtista" HeaderText="Id Artista" />
                    </Columns>
                </asp:GridView>
            </td>
            <td class="style3">
                &nbsp;</td>
            <td class="style9">
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td class="style8">
                &nbsp;</td>
            <td class="style7">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
            <td class="style9">
                <br />
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td class="style8">
                &nbsp;</td>
            <td class="style7">
                <br />
            </td>
            <td class="style3">
                &nbsp;</td>
            <td class="style9">
                <asp:Button ID="btAdGenero" runat="server" Text="Administrar" />
            </td>
        </tr>
    </table>
</asp:Content>

