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

public partial class FrGeneroAdmin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btAtras_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrAdministrar.aspx");
    }

    public Boolean validar()
    {
        if (txId.Text.Equals(""))
        {
            lbMensaje.Text = "Debe ingresar un ID";
            return false;
        }
        else if (txNombre.Text.Equals(""))
        {
            lbMensaje.Text = "Debe ingresar un nombre";
            return false;
        }
        else
            return true;
    }
    protected void btAgregar_Click(object sender, EventArgs e)
    {
        if (validar())
        {
            Genero genero = new Genero(int.Parse(txId.Text), txNombre.Text);
            if (!DAOGenero.sqlInsert(genero))
            {
                lbMensaje.Text = "Error. No se pudo agregar el Genero, porque ya existe";
            }
            else
            {
                lbMensaje.Text = "Genero agregado exitosamente";
            }
        }
    }
    protected void btLeer_Click(object sender, EventArgs e)
    {
        if (txId.Text.Equals(""))
        {
            lbMensaje.Text = "Ingrese un ID para continuar.";
            return;
        }

        Genero genero = DAOGenero.sqlLeer(new Genero(int.Parse(txId.Text)));

        if (genero != null)
        {
            txNombre.Text = genero.Nombre;
            lbMensaje.Text = "Dato seleccionado";
        }
        else
        {
            lbMensaje.Text = "Error. ID no válida.";
            txNombre.Text = "";
        }
    }
    protected void btActualizar_Click(object sender, EventArgs e)
    {
        if (validar())
        {
            Boolean actualiza = DAOGenero.sqlUpdate(new Genero(int.Parse(txId.Text), txNombre.Text));
            lbMensaje.Text = "Dato actualizado exitosamente";
        }
    }
    protected void btEliminar_Click(object sender, EventArgs e)
    {
        if (txId.Text.Equals(""))
        {
            lbMensaje.Text = "debe Ingresar un id";
            return;
        }
        if (txId.Text != null)
        {
            if(DAOGenero.sqlDelete(new Genero(int.Parse(txId.Text))))
            lbMensaje.Text = "Genero eliminado";
            else
                lbMensaje.Text = "no Existe en la base datos";
        }
        else
            lbMensaje.Text = "No se pudo eliminar el genero";
    }
    protected void btDesplegar_Click(object sender, EventArgs e)
    {
        if (btDesplegar.Text == "v")
        {
            grGenero.Visible = true;
            DataTable dt = DAOGenero.sqlLeerTodas();
            grGenero.DataSource = dt;
            grGenero.DataBind();
            btDesplegar.Text = "^";
        }
        else if (btDesplegar.Text == "^")
        {
            grGenero.Visible = false;
            btDesplegar.Text = "v";
        }
    }
}
