<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FrIngresar.aspx.cs" Inherits="FrIngresar" %>

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
                    <asp:Label ID="idMensajeIngresar" runat="server" 
                        Text="Por favor... escribe Nombre y Clave"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <table class="style1">
                        <tr>
                            <td>
                                <asp:Button ID="btAtrás" runat="server" onclick="btAtrás_Click" 
                                    Text="&lt;- Atrás" />
                            </td>
                            <td>
                                <asp:Label ID="idUsuario" runat="server" Text="Usuario: "></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txUsuario" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Button ID="btCerrar" runat="server" Text="Cerrar" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                <asp:Label ID="lbClave" runat="server" Text="Clave: "></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txClave" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td colspan="2">
                                <asp:Button ID="btIngresar" runat="server" Text="Ingresar" 
                                    onclick="btIngresar_Click" />
                            </td>
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
