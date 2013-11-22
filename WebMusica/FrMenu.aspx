<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FrMenu.aspx.cs" Inherits="FrMenu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 778px;
        }
        .style2
        {
            width: 380px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1" border="2">
            <tr>
                <td colspan="2">
                    <asp:Button ID="btAtras" runat="server" onclick="btAtras_Click" 
                        Text="&lt;- Atrás" />
                    <asp:Label ID="lbPregunta" runat="server" Text="¿Qué deseas comprar?"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:Button ID="btDisco" runat="server" Height="150px" onclick="btDisco_Click" 
                        Text="Disco" Width="150px" />
                </td>
                <td class="style2">
                    <asp:Button ID="btCancion" runat="server" Height="150px" Text="Canción" 
                        Width="150px" onclick="btCancion_Click" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
