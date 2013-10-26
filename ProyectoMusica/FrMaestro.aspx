<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FrMaestro.aspx.cs" Inherits="FrMaestro" %>

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
            width: 336px;
        }
        .style3
        {
            width: 254px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1" border="2">
            <tr>
                <td class="style2">
                    <asp:Button ID="btCrearCuenta" runat="server" Height="101px" 
                        Text="Crear Cuenta" Width="343px" onclick="btCrearCuenta_Click" />
                </td>
                <td class="style3">
                    <asp:Button ID="btIngresar" runat="server" Height="101px" Text="Ingresar" 
                        Width="343px" onclick="btIngresar_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btCerrar" runat="server" Height="41px" Text="Cerrar" 
                        Width="729px" onclick="btCerrar_Click" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
