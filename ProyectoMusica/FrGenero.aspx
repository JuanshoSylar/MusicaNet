<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="FrGenero.aspx.cs" Inherits="FrGenero" Title="Página sin título" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="cphContenido" Runat="Server">
    <table class="style1">
        <tr>
            <td>
                <asp:Button ID="btAtras" runat="server" Text="&lt;-Atras" 
                    onclick="btAtras_Click" style="height: 26px" />
            </td>
            <td>
                Genero:<asp:TextBox ID="txGenero" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btBuscar" runat="server" Text="Buscar" />
            </td>
            <td>
                <asp:Button ID="btCancelar" runat="server" Text="Cancelar" />
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:GridView ID="GridView1" runat="server">
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
                &nbsp;</td>
            <td>
                <asp:Button ID="Button2" runat="server" Text="Administrar" />
            </td>
        </tr>
    </table>
</asp:Content>

