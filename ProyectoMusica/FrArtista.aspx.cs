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

public partial class FrArtista : System.Web.UI.Page
{
    DataTable dt;
    protected void Page_Load(object sender, EventArgs e)
    {
        BibliotecaMusica.Entity.Usuarios usuario = (BibliotecaMusica.Entity.Usuarios)Session["usuario"];
        if (BibliotecaMusica.DAO.DAOUsuarios.esAdmin(usuario))
        {
            btAdministrar.Visible = true;
        }
        else
        {
            btAdministrar.Visible = false;
        }
        leer();
    }
    protected void btAtras_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrBuscador.aspx");
    }
    protected void gArtista_SelectedIndexChanged(object sender, EventArgs e)
    {
        DataRow row = dt.Rows[gArtista.SelectedIndex];
        Session["id"] = row["id"].ToString();
    }

    public void leer()
    {
        dt = BibliotecaMusica.DAO.DAOArtista.sqlLeerTodas(txNombre.Text);
        gArtista.DataSource = dt;
        gArtista.DataBind();   
    }//Me tira error en biblioteca musica el error dice que ninguna sobrecarga para el metodo sqlLeerTodas acepta 1 argumento
    protected void btBuscar_Click(object sender, EventArgs e)
    {
        leer();
    }
    protected void btAdministrar_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrArtistaAdmin.aspx");
    }
}
