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
using BibliotecaMusica.Entity;
using BibliotecaMusica.DAO;

public partial class FrCancionAdmin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btAtras_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrCancion.aspx");
    }
    protected void btLeer_Click(object sender, EventArgs e)
    {
        if (txtId.Text.Equals(""))
        {
            lbMensaje.Text = "Ingrese un dato para continuar";
            return;
        }

        Cancion cancion = DAOCancion.sqlLeer(new Cancion(int.Parse(txtId.Text)));
       
        if (cancion != null)
        {
            txtNombre.Text = cancion.Nombre;
            //txtDisco
            txtDisco.Text = cancion.IdDisco.ToString();
          
            lbMensaje.Text = "Dato seleccionado";
        }
        else
        {
            lbMensaje.Text = "Error. ID no válida.";
            txtNombre.Text = "";
            txtDisco.Text = "";
        }
    }
    protected void btAgregar_Click(object sender, EventArgs e)
    {
        Cancion cancion = new Cancion(int.Parse(txtId.Text), txtNombre.Text, int.Parse(txtDisco.Text));
        if (!DAOCancion.sqlInsert(cancion))
        {
            lbMensaje.Text = "Error. No se pudo agregar la cancion";
        }
        else
        {
            lbMensaje.Text = "Cancion agregada exitosamente";
            Session["id"] = cancion;
            this.limpiar();
        }
        
    }
    protected void btEliminar_Click(object sender, EventArgs e)
    {
        if (txtId.Text != null)
        {
            DAOCancion.sqlDelete(new Cancion(int.Parse(txtId.Text)));
            lbMensaje.Text = "cancion eliminado";
            this.limpiar();
        }
        else
            lbMensaje.Text = "No se pudo eliminar el cancion";

       // this.limpiar();
    }

    public void limpiar()
    {
        foreach(Control c in this.Controls)
        {
            if (c is TextBox)
            {
                ((TextBox)c).Text = "";
            }
        }
    }
    protected void btActualizar_Click(object sender, EventArgs e)
    {
        Boolean b = DAOCancion.sqlUpdate(new Cancion(int.Parse(txtId.Text), txtNombre.Text, int.Parse(txtDisco.Text)));
        lbMensaje.Text = "Dato actualizado";
    }
}
