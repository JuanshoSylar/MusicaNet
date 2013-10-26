using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class frCanciones : System.Web.UI.Page
{
    DataTable dt;
    protected void Page_Load(object sender, EventArgs e)
    {
        leer();
    }
  

    public void leer()
    {

        dt = BibliotecaMusica.DAO.DAOCancion.sqlLeerTodas(txtNombreCan.Text);
        grDatosCanciones.DataSource = dt;
        grDatosCanciones.DataBind();


    }
    protected void grDatosCanciones_SelectedIndexChanged(object sender, EventArgs e)
    {
        DataRow row = dt.Rows[grDatosCanciones.SelectedIndex];
        // txtMsg.Text = grDatosCanciones.SelectedIndex.ToString() + row["id"].ToString();
        Session["id"] = row["id"].ToString();
        Response.Redirect("frCancion.aspx");//llena los datos de cancionadmin
    }
    protected void btBuscar_Click1(object sender, EventArgs e)
    {
        leer();
    }
}
