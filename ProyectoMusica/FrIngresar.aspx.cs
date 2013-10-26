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

public partial class FrIngresar : System.Web.UI.Page
{
    public int admin = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btIngresar_Click(object sender, EventArgs e)
    {
        BibliotecaMusica.Entity.Usuarios usuario = new BibliotecaMusica.Entity.Usuarios(txUsuario.Text, txClave.Text);
        if (BibliotecaMusica.DAO.DAOUsuarios.login(usuario))
        {
            Session["usuario"] = txUsuario.Text;
            Response.Redirect("FrBuscador.aspx");
        }
        else
        {
            lbMensaje.Text = "Error de usuario y/o clave";
        }
        
        
    }
    protected void btCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrMaestro.aspx");
    }
}
