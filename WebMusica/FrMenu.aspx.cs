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

public partial class FrMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void btDisco_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrDiscoCliente.aspx");
    }
    protected void btAtras_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrIngresar.aspx");
    }
    protected void btCancion_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrCancionCliente.aspx");
    }
}
