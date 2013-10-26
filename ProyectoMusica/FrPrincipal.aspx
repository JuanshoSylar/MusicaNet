<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FrPrincipal.aspx.cs" Inherits="FrPrincipal" %>

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
                <td colspan="2">
                    <asp:Label ID="lbMensajeInicio" runat="server" Text="¿Qué deseas hacer?"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btCrearCuenta" runat="server" Height="100px" 
                        Text="Crear Cuenta" Width="200px" />
                </td>
                <td>
                    <asp:Button ID="btIngresar" runat="server" Height="100px" 
                        onclick="btIngresar_Click" Text="Ingresar" Width="200px" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
