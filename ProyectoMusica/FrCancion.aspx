<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="FrCancion.aspx.cs" Inherits="FrCancion" Title="Página sin título" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="cphContenido" Runat="Server">
    <table class="style1">
        <tr>
            <td>
                <asp:Label ID="LNombreCancion" runat="server" Text="Nombre de la cancion"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtnombreC" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btLeer" runat="server" Text="Buscar Cancion" 
                    onclick="btLeer_Click" />
            </td>
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
                <asp:GridView ID="GrDatosCancion" runat="server" AutoGenerateColumns="False" 
                    onselectedindexchanged="GrDatosCancion_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="id" HeaderText="Id" />
                        <asp:BoundField DataField="nombre" HeaderText="nombre" />
                        
                        <asp:BoundField DataField="idDisco" HeaderText="Disco" />
                        
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
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="btAtras" runat="server" onclick="btAtras_Click" 
                    Text="&lt;--- Atras " />
            </td>
            <td>
                <asp:Button ID="btAdministrar" runat="server" onclick="btAdministrar_Click" 
                    Text="Administrar" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

