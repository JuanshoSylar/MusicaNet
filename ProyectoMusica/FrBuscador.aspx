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
    
        <table class="style1" border="2">
            <tr>
                <td>
                    <asp:Button ID="btAtras" runat="server" onclick="btAtras_Click" 
                        Text="&lt;- Atrás" />
                </td>
                <td>
                    Buscar por:</td>
                <td>
                    <asp:Button ID="btCerrar" runat="server" Text="Cerrar" 
                        onclick="btCerrar_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btArtista" runat="server" Height="41px" Text="Artista" 
                        Width="99px" />
                </td>
                <td>
                    <asp:Button ID="btDisco" runat="server" Height="41px" onclick="btDisco_Click" 
                        Text="Disco" Width="99px" />
                </td>
                <td>
                    <asp:Button ID="btCanción" runat="server" Height="41px" Text="Canción" 
                        Width="99px" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
