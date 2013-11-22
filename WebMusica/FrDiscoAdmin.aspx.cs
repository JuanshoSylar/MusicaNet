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

public partial class FrDiscoAdmin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) artista();
    }
    protected void btAtras_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrAdministrar.aspx");
    }
    protected void btAgregar_Click(object sender, EventArgs e)
    {
        if (validar())
        {
            int idArtista = int.Parse(cbArtista.SelectedValue);
            Disco disco = new Disco(int.Parse(txId.Text), txNombre.Text, idArtista, int.Parse(txPrecio.Text));
            if (!DAODisco.sqlInsert(disco))
            {
                lbMensaje.Text = "Error. No se pudo agregar el disco, porque ya existe";
            }
            else
            {
                lbMensaje.Text = "Disco agregado exitosamente";
            }
        }
    }

    public void artista()
    {
        cbArtista.DataSource = DAOArtista.sqlComboArtista();
        cbArtista.DataTextField = "nombre";
        cbArtista.DataValueField = "id";
        cbArtista.DataBind();
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
    protected void btLeer_Click(object sender, EventArgs e)
    {
        if (txId.Text.Equals(""))
        {
            lbMensaje.Text = "Ingrese un ID para continuar.";
            return;
        }

        Disco disco = DAODisco.sqlLeer(new Disco(int.Parse(txId.Text)));

        if (disco != null)
        {
            txNombre.Text = disco.Nombre;
            cbArtista.SelectedValue = disco.IdArtista.ToString();
            txPrecio.Text = disco.Precio.ToString();
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
            int idArtista = int.Parse(cbArtista.SelectedValue);
            Boolean actualiza = DAODisco.sqlUpdate(new Disco(int.Parse(txId.Text), txNombre.Text, idArtista, int.Parse(txPrecio.Text)));
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
            if(DAODisco.sqlDelete(new Disco(int.Parse(txId.Text))))
            lbMensaje.Text = "Disco eliminado";
              else
                lbMensaje.Text = "no Existe en la base datos";
        }
        else
            lbMensaje.Text = "No se pudo eliminar el disco";
    }
    protected void btDesplegar_Click(object sender, EventArgs e)
    {
        if (btDesplegar.Text == "v")
        {
            grDisco.Visible = true;
            DataTable dt = DAODisco.sqlLeerTodas();
            grDisco.DataSource = dt;
            grDisco.DataBind();
            btDesplegar.Text = "^";
        }
        else if (btDesplegar.Text == "^")
        {
            grDisco.Visible = false;
            btDesplegar.Text = "v";
        }
    }
}
