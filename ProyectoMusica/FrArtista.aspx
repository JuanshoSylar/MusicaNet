<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="FrArtista.aspx.cs" Inherits="FrArtista" Title="Página sin título" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="cphContenido" Runat="Server">
    <table class="style1">
        <tr>
            <td>
                <asp:Button ID="btAtras" runat="server" onclick="btAtras_Click" 
                    Text="&lt;-Atras" />
            </td>
            <td>
                Nombre:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txNombre" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btBuscar" runat="server" onclick="btBuscar_Click" 
                    Text="Buscar" />
            </td>
            <td>
                <asp:Button ID="btCancelar" runat="server" Text="Cancelar" />
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:GridView ID="gArtista" runat="server" AutoGenerateColumns="False" 
                    onselectedindexchanged="gArtista_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="ID" />
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
                <asp:Button ID="btAdministrar" runat="server" onclick="btAdministrar_Click" 
                    Text="Administrar" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

