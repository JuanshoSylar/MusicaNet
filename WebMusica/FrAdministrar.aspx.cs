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

public partial class FrAdministrar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btAtras_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrIngresar.aspx");
    }
    protected void btArtistas_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrArtistaAdmin.aspx");
    }
    protected void btDiscos_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrDiscoAdmin.aspx");
    }
    protected void btCanciones_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrCancionAdmin.aspx");
    }
    protected void btGeneros_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrGeneroAdmin.aspx");
    }
    protected void btUsuarios_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrUsuarioAdmin.aspx");
    }
}
