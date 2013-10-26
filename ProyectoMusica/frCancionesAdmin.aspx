<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="frCancionesAdmin.aspx.cs" Inherits="frCancionesAdmin" Title="Página sin título" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style6
        {
            width: 4px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="cphContenido" Runat="Server">
    <table class="style5" border="1">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Id"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="btGuardar" runat="server" Text="Guardar" />
            </td>
            <td class="style6">
                <asp:Button ID="btActualizar" runat="server" Text="Actualizar" />
            </td>
            <td>
                <asp:Button ID="btEliminar" runat="server" Text="Eliminar" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style6">
                <asp:Button ID="btBuscar" runat="server" Text="Buscar" 
                    onclick="btBuscar_Click" />
            </td>
            <td>
                <asp:Button ID="btSalir" runat="server" Text="Salir" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Album"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="Album" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style6">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Artista"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtArtista" runat="server" style="margin-bottom: 0px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style6">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Genero"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtGenero" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style6">
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
            <td class="style6">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

