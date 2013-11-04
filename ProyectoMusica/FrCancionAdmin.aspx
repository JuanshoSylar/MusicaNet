<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="FrCancionAdmin.aspx.cs" Inherits="FrCancionAdmin" Title="Página sin título" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="cphContenido" Runat="Server">
    <table class="style1">
        <tr>
            <td>
                <asp:Label ID="lbIdCan" runat="server" Text="Id"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btAgregar" runat="server" Text="Agregar" 
                    onclick="btAgregar_Click" />
            </td>
            <td>
                <asp:Button ID="btActualizar" runat="server" Text="Actualizar" 
                    onclick="btActualizar_Click" />
            </td>
            <td>
                <asp:Button ID="btEliminar" runat="server" Text="Eliminar" 
                    onclick="btEliminar_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lbNombre" runat="server" Text="Nombre"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btAtras" runat="server" onclick="btAtras_Click" Text="?" />
            </td>
            <td>
                <asp:Button ID="btLeer" runat="server" onclick="btLeer_Click" Text="Leer" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LbArtista" runat="server" Text="Disco"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDisco" runat="server"></asp:TextBox>
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
        <tr>
            <td>
                <asp:Label ID="lbMensaje" runat="server" Text="  "></asp:Label>
            </td>
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

