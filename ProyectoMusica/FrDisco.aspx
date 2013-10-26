<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="FrDisco.aspx.cs" Inherits="FrCompositor" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style2
        {
            width: 133px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphContenido" Runat="Server">
    <table class="style1">
    <tr>
        <td class="style2">
            <asp:Button ID="btAtras" runat="server" Text="&lt;- Atrás" 
                onclick="btAtras_Click" />
        </td>
        <td>
            <asp:Label ID="lbNombre" runat="server" Text="Nombre: "></asp:Label>
            <asp:TextBox ID="txNombre" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:Button ID="btBuscar" runat="server" Text="Buscar" 
                onclick="btBuscar_Click" />
        </td>
        <td>
            <asp:Button ID="btCerrar" runat="server" Text="Cerrar" />
        </td>
    </tr>
    <tr>
        <td class="style2">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style2">
            &nbsp;</td>
        <td>
            <asp:GridView ID="grDatosCompositor" runat="server" AutoGenerateColumns="False" 
                onselectedindexchanged="grDatosCompositor_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField HeaderText="ID" DataField="id" />
                    <asp:BoundField HeaderText="Nombre" DataField="nombre" />
                </Columns>
            </asp:GridView>
        </td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style2">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            <asp:Button ID="btAdministrar" runat="server" Text="Administrar" />
        </td>
    </tr>
</table>
</asp:Content>

