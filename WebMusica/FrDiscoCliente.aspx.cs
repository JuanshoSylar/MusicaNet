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

public partial class FrDiscoCliente : System.Web.UI.Page
{
    DataTable dt;
    protected void Page_Load(object sender, EventArgs e)
    {
        leer();
    }
    protected void btAtras_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrMenu.aspx");
    }
    protected void btBuscar_Click(object sender, EventArgs e)
    {
        leer();
    }

    public void leer()
    {
        dt = DAODisco.sqlLeerTodas(txNombre.Text);
        grDatosDisco.DataSource = dt;
        grDatosDisco.DataBind();
    }
}
