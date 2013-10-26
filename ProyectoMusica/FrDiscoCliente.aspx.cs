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

public partial class FrDiscoCliente : System.Web.UI.Page
{
    DataTable dt;
    protected void Page_Load(object sender, EventArgs e)
    {
        leer();
        botonAdministrar();
    }
    protected void btAtras_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrBuscador.aspx");
    }
    protected void btAdministrar_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrDiscoAdmin.aspx");
    }
    protected void grDatos_SelectedIndexChanged(object sender, EventArgs e)
    {
        DataRow row = dt.Rows[grDatos.SelectedIndex];
    }

    private void leer()
    {
        dt = BibliotecaMusica.DAO.DAODisco.sqlLeerTodas(4, txNombre.Text);
        grDatos.DataSource = dt;
        grDatos.DataBind();
    }

    private void botonAdministrar()
    {
        String sUsuario = "";
        if (Session["usuario"] != null)
        {
            sUsuario = Session["usuario"].ToString();
        }
        BibliotecaMusica.Entity.Usuarios usuario = new BibliotecaMusica.Entity.Usuarios(sUsuario);
        Boolean bAdmin = BibliotecaMusica.DAO.DAOUsuarios.esAdmin(usuario);
        if (bAdmin)
        {
            btAdministrar.Visible = true;
        }
        else
            btAdministrar.Visible = false;
    }

    protected void btBuscar_Click(object sender, EventArgs e)
    {
        leer();
    }
}
