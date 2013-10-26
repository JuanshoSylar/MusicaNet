<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="FrDiscoAdmin.aspx.cs" Inherits="FrDiscoAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphContenido" Runat="Server">
    <table class="style1">
        <tr>
            <td>
                <asp:Label ID="lbId" runat="server" Text="ID"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txId" runat="server"></asp:TextBox>
                <asp:Button ID="btDiscoHelp" runat="server" Text="?" />
            </td>
            <td>
                <asp:Button ID="btLeer" runat="server" Text="Leer" />
            </td>
            <td>
                <asp:Button ID="btCerrar" runat="server" Text="Cerrar" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lbNombre" runat="server" Text="Nombre"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txNombre" runat="server"></asp:TextBox>
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
                <asp:Button ID="btGrabar" runat="server" Text="Grabar" />
            </td>
            <td>
                <asp:Button ID="btEliminar" runat="server" Text="Eliminar" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btAtras" runat="server" onclick="btAtras_Click" 
                    Text="&lt;- Atras" />
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

