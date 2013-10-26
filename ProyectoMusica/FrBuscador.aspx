<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FrBuscador.aspx.cs" Inherits="FrBuscador" %>

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
    
        <table class="style1">
            <tr>
                <td colspan="2">
                    <asp:Button ID="btAtras" runat="server" Text="&lt;- Atrás" />
                </td>
                <td colspan="2">
                    <asp:Label ID="lbMensaje" runat="server" Text="¿Qué deseas buscar?"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:Button ID="btCerrar" runat="server" Text="Cerrar" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Height="50px" Text="Button" 
                        Width="100px" />
                </td>
                <td colspan="2">
                    <asp:Button ID="Button2" runat="server" Height="50px" Text="Button" 
                        Width="100px" />
                </td>
                <td colspan="2">
                    <asp:Button ID="Button3" runat="server" Height="50px" Text="Button" 
                        Width="100px" />
                </td>
                <td>
                    <asp:Button ID="Button4" runat="server" Height="50px" Text="Button" 
                        Width="100px" />
                </td>
            </tr>
            <tr>
                <td colspan="6">
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
