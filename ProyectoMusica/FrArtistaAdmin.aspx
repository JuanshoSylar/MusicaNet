<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="FrArtistaAdmin.aspx.cs" Inherits="FrArtistaAdmin" Title="Página sin título" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="cphContenido" Runat="Server">
    <table class="style1">
        <tr>
            <td>
                ID:</td>
            <td>
                <asp:TextBox ID="txId" runat="server"></asp:TextBox>
                <asp:Button ID="btHelp" runat="server" onclick="btHelp_Click" Text="?" />
            </td>
            <td>
                <asp:Button ID="btLeer" runat="server" onclick="btLeer_Click" Text="Leer" />
            </td>
            <td>
                <asp:Button ID="btCerrar" runat="server" Text="Cerrar" 
                    onclick="btCerrar_Click" />
            </td>
        </tr>
        <tr>
            <td>
                Nombre:</td>
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
                &nbsp;</td>
            <td>
                <asp:Label ID="LbMensaje" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btAgregar" runat="server" onclick="btAgregar_Click" 
                    Text="Agregar" />
            </td>
            <td>
                <asp:Button ID="btActualizar" runat="server" onclick="btActualizar_Click" 
                    Text="Actualizar" />
            </td>
            <td>
                <asp:Button ID="btEliminar" runat="server" Text="Eliminar" 
                    onclick="btEliminar_Click" />
            </td>
            <td>
                <asp:Button ID="btLimpiar" runat="server" Text="Limpiar" 
                    onclick="btLimpiar_Click" />
            </td>
        </tr>
    </table>
</asp:Content>

