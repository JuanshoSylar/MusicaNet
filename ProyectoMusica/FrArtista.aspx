<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="FrArtista.aspx.cs" Inherits="FrArtistaspx" Title="Página sin título" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>


<asp:Content ID="Content4" ContentPlaceHolderID="cphContenido" Runat="Server">
    <table class="style1">
        <tr>
            <td>
                <asp:Button ID="btAtras" runat="server" onclick="btAtras_Click" Text="Atras" />
            </td>
            <td>
                ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txId" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btBuscar" runat="server" Text="Buscar" />
            </td>
            <td>
                <asp:Button ID="btCerrar" runat="server" Text="Cerrar" />
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:GridView ID="gDatos" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="id" HeaderText="ID" />
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                    </Columns>
                </asp:GridView>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="btAdministrar" runat="server" Text="Administrar" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

