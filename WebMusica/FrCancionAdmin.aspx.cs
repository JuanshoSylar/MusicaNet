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

public partial class FrCancionAdmin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) disco();
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
        else if (txPrecio.Text.Equals(""))
        {
            lbMensaje.Text = "Debe ingresar un precio";

            return false;
        }
        else
            return true;
    }
    protected void btAgregar_Click(object sender, EventArgs e)
    {
        if (validar())
        {
            int idDisco = int.Parse(cbDisco.SelectedValue);

            Cancion cancion = new Cancion(int.Parse(txId.Text), txNombre.Text, idDisco, int.Parse(txPrecio.Text));
            if (!DAOCancion.sqlInsert(cancion))
            {
                lbMensaje.Text = "Error. No se pudo agregar la canción, porque ya existe ";
            }
            else
            {
                lbMensaje.Text = "Canción agregada exitosamente";
            }
        }
    }

    public void disco()
    {
        cbDisco.DataSource = DAODisco.sqlComboDisco();
        cbDisco.DataTextField = "nombre";
        cbDisco.DataValueField = "id";
        cbDisco.DataBind();
    }

   
    protected void btLeer_Click(object sender, EventArgs e)
    {
        if (txId.Text.Equals(""))
        {
            lbMensaje.Text = "Ingrese un ID para continuar.";
            return;
        }

        Cancion cancion = DAOCancion.sqlLeer(new Cancion(int.Parse(txId.Text)));

        if (cancion != null)
        {
            txNombre.Text = cancion.Nombre;
            cbDisco.SelectedValue = cancion.IdDisco.ToString();
            txPrecio.Text = cancion.Precio.ToString();
            lbMensaje.Text = "Dato seleccionado";
        }
        else
        {
            lbMensaje.Text = "Error. ID no válida.";
            txNombre.Text = "";
            txPrecio.Text = "";
        }
    }
    protected void btActualizar_Click(object sender, EventArgs e)
    {
        if (validar())
        {
            int idDisco = int.Parse(cbDisco.SelectedValue);
            Boolean actualiza = DAOCancion.sqlUpdate(new Cancion(int.Parse(txId.Text), txNombre.Text, idDisco, int.Parse(txPrecio.Text)));
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
            if (DAOCancion.sqlDelete(new Cancion(int.Parse(txId.Text))))
                lbMensaje.Text = "Canción eliminada";
            else
                lbMensaje.Text = "no existe en la base de datos";
        }
        else
            lbMensaje.Text = "No se pudo eliminar la canción";
    }
    protected void btDesplegar_Click(object sender, EventArgs e)
    {
        if (btDesplegar.Text == "v")
        {
            grCancion.Visible = true;
            DataTable dt = DAOCancion.sqlLeerTodas();
            grCancion.DataSource = dt;
            grCancion.DataBind();
            btDesplegar.Text = "^";
        }
        else if (btDesplegar.Text == "^")
        {
            grCancion.Visible = false;
            btDesplegar.Text = "v";
        }
    }
}
