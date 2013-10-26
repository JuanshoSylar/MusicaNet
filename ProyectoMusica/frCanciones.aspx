<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="frCanciones.aspx.cs" Inherits="frCanciones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style2
        {
            width: 237px;
        }
        .style5
        {
            width: 237px;
        }
        .style6
        {
            height: 20px;
        }
        </style>
</asp:Content>


<asp:Content ID="Content4" ContentPlaceHolderID="cphContenido" Runat="Server">
    <table class="style2" border="0">
        <tr>
            <td class="style5">
                <asp:Label ID="lbNombreCan" runat="server" Text="nombre "></asp:Label>
                <asp:TextBox ID="txtNombreCan" runat="server" Height="22px" Width="128px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="btBuscar" runat="server" Text="Buscar" 
                    onclick="btBuscar_Click1" />
            </td>
        </tr>
        <tr>
            <td class="style5">
                <asp:GridView ID="grDatosCanciones" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField HeaderText="ID" DataField="id" />
                        <asp:BoundField HeaderText="Nombre" DataField="nombre" />
                        <asp:BoundField HeaderText="Artista" DataField="idArtista" />
                    </Columns>
                </asp:GridView>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6" colspan="4">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

