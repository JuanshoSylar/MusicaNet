using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using BlMusica.Entity;
using BlMusica.DAO;

public partial class FrCrearCuenta : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btAtras_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrPrincipal.aspx");
    }
    protected void btIngresar_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrIngresar.aspx");
    }
    protected void btRegistrar_Click(object sender, EventArgs e)
    {
        if (validar())
        {
            Usuarios usuario = new Usuarios(txUsuario.Text, txClave.Text);
            if (DAOUsuarios.sqlInsert(usuario))
            {
                lbMensaje.Text = "Cuenta creada exitosamente.";
            }
            else
            {
                lbMensaje.Text = "No se pudo crear la cuenta.";
            }
        }
    }

    public Boolean validar()
    {
        if (txUsuario.Text.Equals(""))
        {
            lbMensaje.Text = "Error. Debe escribir el nombre de usuario.";
            return false;
        }
        else if (txClave.Text.Equals(""))
        {
            lbMensaje.Text = "Error. Debe escribir una clave.";
            return false;
        }
        else
            return true;
    }
}
