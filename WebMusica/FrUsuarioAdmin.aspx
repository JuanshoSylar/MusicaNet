<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FrUsuarioAdmin.aspx.cs" Inherits="FrUsuarioAdmin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style3
        {
            width: 196px;
        }
        .style4
        {
            width: 134px;
        }
        .style5
        {
            width: 126px;
        }
        .style6
        {
            width: 126px;
            height: 149px;
        }
        .style7
        {
            width: 196px;
            height: 149px;
        }
        .style8
        {
            width: 134px;
            height: 149px;
        }
        .style9
        {
            height: 149px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1" border="2">
            <tr>
                <td>
                    <asp:Button ID="btAtras" runat="server" Text="&lt;- Atras" 
                        onclick="btAtras_Click" />
                    <asp:Label ID="lbMensaje" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <table class="style1">
                        <tr>
                            <td class="style5">
                                <asp:Label ID="lbUsuario" runat="server" Text="Usuario: "></asp:Label>
                            </td>
                            <td class="style3">
                                <asp:TextBox ID="txUsuario" runat="server"></asp:TextBox>
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
                            <td class="style6">
                                <asp:Label ID="lbClave" runat="server" Text="Clave: "></asp:Label>
                            </td>
                            <td class="style7">
                                <asp:TextBox ID="txClave" runat="server"></asp:TextBox>
                            </td>
                            <td class="style8">
                                </td>
                            <td class="style9">
                                <asp:GridView ID="grUsuarios" runat="server" AutoGenerateColumns="False">
                                    <Columns>
                                        <asp:BoundField DataField="usuario" HeaderText="Usuario" />
                                        <asp:BoundField DataField="clave" HeaderText="Clave" />
                                        <asp:BoundField DataField="esAdmin" HeaderText="¿Es admin?" />
                                    </Columns>
                                </asp:GridView>
                            </td>
                            <td class="style9">
                                </td>
                        </tr>
                        <tr>
                            <td class="style5">
                                <asp:Label ID="lbEsAdmin" runat="server" Text="¿Es Admin?: "></asp:Label>
                            </td>
                            <td class="style3">
                                <asp:TextBox ID="txEsAdmin" runat="server" Width="20px"></asp:TextBox>
                                <asp:Label ID="lbExplicacion" runat="server" Font-Italic="True" 
                                    Text="Si: 1 / No: 0"></asp:Label>
                            </td>
                            <td class="style4">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style5">
                                &nbsp;</td>
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
