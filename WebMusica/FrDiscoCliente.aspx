<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FrDiscoCliente.aspx.cs" Inherits="FrDiscoCliente" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1" border="2">
            <tr>
                <td>
                    <asp:Label ID="lbMensaje" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <table class="style1">
                        <tr>
                            <td>
                                <asp:Button ID="btAtras" runat="server" onclick="btAtras_Click" 
                                    Text="&lt;- Atrás" />
                            </td>
                            <td>
                                <asp:Label ID="lbNombre" runat="server" Text="Nombre Disco: "></asp:Label>
                                <asp:TextBox ID="txNombre" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Button ID="btBuscar" runat="server" onclick="btBuscar_Click" 
                                    Text="Buscar" />
                            </td>
                        </tr>
                        <tr>
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
                                <asp:GridView ID="grDatosDisco" runat="server" AutoGenerateColumns="False">
                                    <Columns>
                                        <asp:BoundField DataField="id" HeaderText="ID" />
                                        <asp:BoundField DataField="nomDisco" HeaderText="Nombre" />
                                        <asp:BoundField DataField="nomArtista" HeaderText="Artista" />
                                        <asp:BoundField DataField="nomGenero" HeaderText="Genero" />
                                        <asp:BoundField DataField="precio" HeaderText="Precio" />
                                        <asp:ButtonField Text="Comprar" />
                                    </Columns>
                                </asp:GridView>
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
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
