<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FrDiscoAdmin.aspx.cs" Inherits="FrDiscoAdmin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 120px;
        }
        .style3
        {
            width: 217px;
        }
        .style4
        {
            width: 115px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1" border="2">
            <tr>
                <td>
                    <asp:Button ID="btAtras" runat="server" onclick="btAtras_Click" 
                        Text="&lt;- Atrás" />
                    <asp:Label ID="lbMensaje" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <table class="style1">
                        <tr>
                            <td class="style2">
                                <asp:Label ID="btId" runat="server" Text="ID: "></asp:Label>
                            </td>
                            <td class="style3">
                                <asp:TextBox ID="txId" runat="server"></asp:TextBox>
                            </td>
                            <td class="style4">
                                <asp:Button ID="btLeer" runat="server" onclick="btLeer_Click" Text="Leer" />
                            </td>
                            <td>
                                <asp:Button ID="btDesplegar" runat="server" onclick="btDesplegar_Click" 
                                    Text="v" />
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style2">
                                <asp:Label ID="lbNombre" runat="server" Text="Nombre: "></asp:Label>
                            </td>
                            <td class="style3">
                                <asp:TextBox ID="txNombre" runat="server"></asp:TextBox>
                            </td>
                            <td class="style4">
                                &nbsp;</td>
                            <td>
                                <asp:GridView ID="grDisco" runat="server" AutoGenerateColumns="False">
                                    <Columns>
                                        <asp:BoundField DataField="id" HeaderText="ID" />
                                        <asp:BoundField DataField="nomDisco" HeaderText="Nombre" />
                                        <asp:BoundField DataField="nomArtista" HeaderText="Artista" />
                                        <asp:BoundField DataField="precio" HeaderText="Precio" />
                                    </Columns>
                                </asp:GridView>
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style2">
                                <asp:Label ID="lbArtista" runat="server" Text="Artista: "></asp:Label>
                            </td>
                            <td class="style3">
                                <asp:DropDownList ID="cbArtista" runat="server" Width="126px">
                                </asp:DropDownList>
                            </td>
                            <td class="style4">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style2">
                                <asp:Label ID="lbPrecio" runat="server" Text="Precio: "></asp:Label>
                            </td>
                            <td class="style3">
                                <asp:TextBox ID="txPrecio" runat="server"></asp:TextBox>
                            </td>
                            <td class="style4">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style2">
                                <asp:Button ID="btAgregar" runat="server" onclick="btAgregar_Click" 
                                    Text="Agregar" />
                            </td>
                            <td class="style3">
                                <asp:Button ID="btActualizar" runat="server" onclick="btActualizar_Click" 
                                    Text="Actualizar" />
                            </td>
                            <td class="style4">
                                <asp:Button ID="btEliminar" runat="server" onclick="btEliminar_Click" 
                                    Text="Eliminar" />
                            </td>
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
