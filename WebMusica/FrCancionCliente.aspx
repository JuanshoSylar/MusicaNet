<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FrCancionCliente.aspx.cs" Inherits="FrCancionCliente" %>

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
                                <asp:Label ID="lbNombre" runat="server" Text="Nombre Canción: "></asp:Label>
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
                                <asp:GridView ID="grDatosCancion" runat="server" AutoGenerateColumns="False">
                                    <Columns>
                                        <asp:BoundField DataField="id" HeaderText="ID" />
                                        <asp:BoundField DataField="nomCancion" HeaderText="Nombre" />
                                        <asp:BoundField DataField="nomDisco" HeaderText="Disco" />
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
