<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="FrDiscoAdmin.aspx.cs" Inherits="FrDiscoAdmin" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphContenido" Runat="Server">
    <table class="style1">
        <tr>
            <td>
                <asp:Label ID="lbId" runat="server" Text="ID: "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txId" runat="server"></asp:TextBox>
                <asp:Button ID="btAyuda" runat="server" onclick="btAyuda_Click" Text="?" />
            </td>
            <td>
                <asp:Button ID="btLeer" runat="server" onclick="btLeer_Click" Text="Leer" />
            </td>
            <td>
                <asp:Button ID="btCerrar" runat="server" Text="Cerrar" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lbNombre" runat="server" Text="Nombre: "></asp:Label>
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
                <asp:Label ID="lbArtista" runat="server" Text="Artista: "></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="cbArtista" runat="server">
                </asp:DropDownList>
            </td>
            <td>
                <asp:Label ID="lbMensaje" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
            
                <asp:Label ID="lbPrecio" runat="server" Text="Precio: "></asp:Label>            
            </td>
            <td>
                <asp:TextBox ID="txPrecio" runat="server"></asp:TextBox>
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btAgregar" runat="server" onclick="btAgregar_Click" 
                    Text="Agregar" />
            </td>
            <td>
                <asp:Button ID="btActualizar" runat="server" Text="Actualizar" 
                    onclick="btActualizar_Click" />
            </td>
            <td>
                <asp:Button ID="btEliminar" runat="server" Text="Eliminar" 
                    onclick="btEliminar_Click" />
            </td>
            <td>
                <asp:Button ID="btLimpiar" runat="server" Text="Limpiar" />
            </td>
        </tr>
    </table>
</asp:Content>

