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

public partial class FrMaestro : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btCrearCuenta_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrCrearCuenta.aspx");
    }
    protected void btIngresar_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrIngresar.aspx");
    }
    protected void btCerrar_Click(object sender, EventArgs e)
    {

    }
}
