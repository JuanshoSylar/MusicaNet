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

public partial class FrDiscoAdmin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btLeer_Click(object sender, EventArgs e)
    {
        
    }
    protected void btAgregar_Click(object sender, EventArgs e)
    {
        BibliotecaMusica.Entity.Disco disco = new BibliotecaMusica.Entity.Disco(int.Parse(txId.Text), txNombre.Text, int.Parse(txArtista.Text));
        if (!BibliotecaMusica.DAO.DAODisco.sqlInsert(disco))
        {
            lbMensaje.Text = "Error. No se pudo agregar el disco";
        }
        else
        {
            lbMensaje.Text = "Disco agregado exitosamente";
            Session["id"] = disco;
        }

        
        
    }
    protected void btAyuda_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrDisco.aspx");
    }
}
