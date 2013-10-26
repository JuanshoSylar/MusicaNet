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

public partial class FrCancion : System.Web.UI.Page
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
    protected void btLeer_Click(object sender, EventArgs e)
    {
        leer();

    }
    protected void GrDatosCancion_SelectedIndexChanged(object sender, EventArgs e)
    {
        DataRow row = dt.Rows[GrDatosCancion.SelectedIndex];
        Session["id"] = row["id"].ToString();
    }

    public void leer()
    {
        dt = BibliotecaMusica.DAO.DAOCancion.sqlLeerTodas(txtnombreC.Text);
        GrDatosCancion.DataSource = dt;
        GrDatosCancion.DataBind();
    }
}
