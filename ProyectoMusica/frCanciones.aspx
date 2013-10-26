<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="frCanciones.aspx.cs" Inherits="frCanciones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style2
        {
            width: 237px;
        }
        .style3
        {
            width: 247px;
        }
    .style4
    {
        width: 240px;
    }
        .style5
        {
            width: 237px;
        }
        .style6
        {
            height: 20px;
        }
        .style7
        {
            height: 20px;
        }
    </style>
</asp:Content>


<asp:Content ID="Content4" ContentPlaceHolderID="cphContenido" Runat="Server">
    <table class="style2" border="0">
        <tr>
            <td class="style5">
                <asp:Label ID="lbNombreCan" runat="server" Text="nombre "></asp:Label>
                <asp:TextBox ID="txtNombreCan" runat="server" Height="22px" Width="128px"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Genero" runat="server" Text="Genero"></asp:Label>
                <asp:TextBox ID="txtGeneroCan" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="lbArtistaCan" runat="server" Text="Artista:"></asp:Label>
                <asp:TextBox ID="txtArtistaCan" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btBuscar" runat="server" Text="Buscar" />
            </td>
        </tr>
        <tr>
            <td class="style5">
                <asp:GridView ID="grDatosCanciones" runat="server">
                    <Columns>
                        <asp:BoundField HeaderText="ID" />
                        <asp:BoundField HeaderText="Nombre" />
                        <asp:BoundField HeaderText="Genero" />
                        <asp:BoundField HeaderText="Album" />
                        <asp:BoundField HeaderText="Artista" />
                        <asp:BoundField />
                        <asp:ButtonField ImageUrl="~/imagenes/images.jpg" Text="Añadir al Carrito" />
                    </Columns>
                </asp:GridView>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6" colspan="4">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

