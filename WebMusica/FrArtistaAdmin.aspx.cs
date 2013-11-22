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

public partial class FrArtistaAdmin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) genero();
    }
    protected void btAtras_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrAdministrar.aspx");
    }

    public void genero()
    {
        cbGenero.DataSource = DAOGenero.sqlComboGenero();
        cbGenero.DataTextField = "nombre";
        cbGenero.DataValueField = "id";
        cbGenero.DataBind();
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
            int idGenero = int.Parse(cbGenero.SelectedValue);
            Artista artista = new Artista(int.Parse(txId.Text), txNombre.Text, idGenero);
            if (!DAOArtista.sqlInsert(artista))
            {
                lbMensaje.Text = "Error. No se pudo agregar el artista, porque ya existe";
            }
            else
            {
                lbMensaje.Text = "Artista agregado exitosamente";
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

        Artista artista = DAOArtista.sqlLeer(new Artista(int.Parse(txId.Text)));

        if (artista != null)
        {
            txNombre.Text = artista.Nombre;
            cbGenero.SelectedValue = artista.IdGenero.ToString();
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
            int idGenero = int.Parse(cbGenero.SelectedValue);
            Boolean actualiza = DAOArtista.sqlUpdate(new Artista(int.Parse(txId.Text), txNombre.Text, idGenero));
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
            if (DAOArtista.sqlDelete(new Artista(int.Parse(txId.Text))))
                lbMensaje.Text = "Artista eliminado";
            else
                lbMensaje.Text = "no Existe en la base datos";
        }
        else
            lbMensaje.Text = "No se pudo eliminar el artista";
    }
    protected void btDesplegar_Click(object sender, EventArgs e)
    {
        if (btDesplegar.Text == "v")
        {
            grArtista.Visible = true;
            DataTable dt = DAOArtista.sqlLeerTodas();
            grArtista.DataSource = dt;
            grArtista.DataBind();
            btDesplegar.Text = "^";
        }
        else if (btDesplegar.Text == "^")
        {
            grArtista.Visible = false;
            btDesplegar.Text = "v";
        }
    }
}
