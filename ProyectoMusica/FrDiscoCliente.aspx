<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="FrDiscoCliente.aspx.cs" Inherits="FrDiscoCliente" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphContenido" Runat="Server">
    <table class="style1">
        <tr>
            <td>
                <asp:Button ID="btAtras" runat="server" onclick="btAtras_Click" 
                    Text="&lt;- Atrás" />
            </td>
            <td>
                <asp:Label ID="lbNombre" runat="server" Text="Nombre: "></asp:Label>
                <asp:TextBox ID="txNombre" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btBuscar" runat="server" onclick="btBuscar_Click" 
                    Text="Buscar" />
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
                <asp:GridView ID="grDatos" runat="server" AutoGenerateColumns="False" 
                    onselectedindexchanged="grDatos_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="id" HeaderText="ID" />
                        <asp:BoundField DataField="nombre" HeaderText="Nombre" />
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
                <asp:Button ID="btAdministrar" runat="server" onclick="btAdministrar_Click" 
                    Text="Administrar" />
            </td>
        </tr>
    </table>
</asp:Content>

