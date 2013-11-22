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

public partial class FrIngresar : System.Web.UI.Page
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
        Usuarios usuario = new Usuarios(txUsuario.Text, txClave.Text);
        if (!DAOUsuarios.login(usuario))
        {
            lbMensaje.Text = "Error. Usuario y/o Clave incorrecto.";
        }
        else
        {
            Session["usuario"] = usuario;
            Usuarios usuario1 = (Usuarios)Session["usuario"];
            if (DAOUsuarios.esAdmin(usuario))
            {
                Response.Redirect("FrAdministrar.aspx");
            }
            else
            {
                Response.Redirect("FrMenu.aspx");
            }
        }
    }
}
