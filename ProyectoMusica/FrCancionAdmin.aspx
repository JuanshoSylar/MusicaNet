<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="FrCancionAdmin.aspx.cs" Inherits="FrCancionAdmin" Title="Página sin título" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="cphContenido" Runat="Server">
    <table class="style1">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Id"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btAgregar" runat="server" Text="Agregar" />
            </td>
            <td>
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
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Artista"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtArtista" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Genero"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtGenero" runat="server"></asp:TextBox>
            </td>
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
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

