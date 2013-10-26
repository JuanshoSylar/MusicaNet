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
    
        <asp:Label ID="lbMensaje" runat="server" Text=""></asp:Label>
    
        <table class="style1" border="2">
            <tr>
                <td>
                    <asp:Label ID="lbUsuario" runat="server" Text="Usuario"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txUsuario" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lbClave" runat="server" Text="Clave"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txClave" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btIngresar" runat="server" onclick="btIngresar_Click" 
                        Text="Ingresar" />
                </td>
                <td>
                    <asp:Button ID="btCancelar" runat="server" Text="Cancelar" 
                        onclick="btCancelar_Click" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
