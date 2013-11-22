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
        .style2
        {
            width: 115px;
        }
        .style3
        {
            width: 57px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1" border="2">
            <tr>
                <td colspan="2">
                    <asp:Label ID="lbMusica" runat="server" Text="Música"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:Button ID="btCrearCuenta" runat="server" Height="110px" 
                        Text="Crear Cuenta" onclick="btCrearCuenta_Click" />
                </td>
                <td class="style3">
                    <asp:Button ID="btIngresar" runat="server" Height="110px" 
                        onclick="btIngresar_Click" Text="Ingresar" Width="110px" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
