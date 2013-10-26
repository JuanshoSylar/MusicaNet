<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="FrGeneroAdmin.aspx.cs" Inherits="FrGeneroAdmin" Title="Página sin título" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphContenido" Runat="Server">
    <table class="style1">
        <tr>
            <td>
                Id:</td>
                                    <td>
                                        <asp:TextBox ID="txId" runat="server"></asp:TextBox>
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
                                        Nombre:</td>
                                    <td>
                                        <asp:TextBox ID="txNombre" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Button ID="btHelp" runat="server" Text="?" />
                                    </td>
                                    <td>
                                        <asp:Button ID="btCancelar" runat="server" Text="Cancelar" />
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td>
                                        Artista:</td>
            <td>
                <asp:TextBox ID="txIdArtista" runat="server"></asp:TextBox>
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

