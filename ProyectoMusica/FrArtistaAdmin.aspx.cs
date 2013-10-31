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

public partial class FrArtistaAdmin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btHelp_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrArtista.aspx");
    }
    protected void btLeer_Click(object sender, EventArgs e)
    {

    }
    protected void btAgregar_Click(object sender, EventArgs e)
    {
        BibliotecaMusica.Entity.Artista artista = new BibliotecaMusica.Entity.Artista(int.Parse(txId.Text), txNombre.Text);
        if (!BibliotecaMusica.DAO.DAOArtista.sqlInsert(artista))
        {
            LbMensaje.Text = "Error. No se pudo agregar el disco";
        }
        else
        {
            LbMensaje.Text = "Disco agregado exitosamente";
            Session["id"] = artista;
        }
    }
    protected void btActualizar_Click(object sender, EventArgs e)
    {

    }
}
