<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FrAdministrar.aspx.cs" Inherits="FrAdministrar" %>

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
                <td colspan="3">
                    <asp:Button ID="btAtras" runat="server" onclick="btAtras_Click" 
                        Text="&lt;- Atrás" />
                    <asp:Label ID="lbMensajeAdmin" runat="server" Text="¿Qué deseas administrar?"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btArtistas" runat="server" Text="Artistas" Width="100px" 
                        onclick="btArtistas_Click" />
                </td>
                <td>
                    <asp:Button ID="btDiscos" runat="server" Text="Discos" Width="100px" 
                        onclick="btDiscos_Click" />
                </td>
                <td>
                    <asp:Button ID="btCanciones" runat="server" Text="Canciones" Width="100px" 
                        onclick="btCanciones_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btGeneros" runat="server" Text="Generos" Width="100px" 
                        onclick="btGeneros_Click" />
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Button ID="btUsuarios" runat="server" Text="Usuarios" Width="100px" 
                        onclick="btUsuarios_Click" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
