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

public partial class FrCompositor : System.Web.UI.Page
{
    DataTable dt;
    protected void Page_Load(object sender, EventArgs e)
    {
        leer();
    }
    protected void btAtras_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrBuscador.aspx");
    }
    protected void grDatosCompositor_SelectedIndexChanged(object sender, EventArgs e)
    {
        DataRow row = dt.Rows[grDatosCompositor.SelectedIndex];
        //txMsg.Text = grDatosCompositor.SelectedIndex.ToString() + row["id"].ToString();
    }
    protected void btBuscar_Click(object sender, EventArgs e)
    {
        leer();
    }

    private void leer()
    {
        
    }
}
