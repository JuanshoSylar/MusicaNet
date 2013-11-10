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
using BibliotecaMusica.DAO;
using BibliotecaMusica.Entity;

public partial class FrDiscoAdmin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        artista();
    }
    protected void btLeer_Click(object sender, EventArgs e)
    {
        int idArtista = int.Parse(cbArtista.SelectedValue);
        if (txId.Text.Equals(""))
        {
            lbMensaje.Text = "Ingrese un ID para continuar.";
            return;
        }

        Disco disco = DAODisco.sqlLeer(new Disco(int.Parse(txId.Text)));
        
        if (disco != null)
        {
            txNombre.Text = disco.Nombre;
            //txArtista.Text = disco.IdArtista.ToString();
            cbArtista.SelectedValue = disco.IdArtista.ToString();
            lbMensaje.Text = "Dato seleccionado";
        }
        else
        {
            lbMensaje.Text = "Error. ID no válida.";
            txNombre.Text = "";
            txArtista.Text = "";
        }
    }
    protected void btAgregar_Click(object sender, EventArgs e)
    {
        //Disco disco = new Disco(int.Parse(txId.Text), txNombre.Text, int.Parse(txArtista.Text));
        int idArtista = int.Parse(cbArtista.SelectedValue);
        Disco disco = new Disco(int.Parse(txId.Text), txNombre.Text, idArtista);
        if (!DAODisco.sqlInsert(disco))
        {
            lbMensaje.Text = "Error. No se pudo agregar el disco";
        }
        else
        {
            lbMensaje.Text = "Disco agregado exitosamente";
            Session["id"] = disco;
        }        
    }

    protected void btAyuda_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrDisco.aspx");
    }

    protected void btActualizar_Click(object sender, EventArgs e)
    {
        int idArtista = int.Parse(cbArtista.SelectedValue);
        Boolean actualiza = DAODisco.sqlUpdate(new Disco(int.Parse(txId.Text), txNombre.Text, idArtista));
        lbMensaje.Text = "Dato actualizado exitosamente";
    }

    protected void btEliminar_Click(object sender, EventArgs e)
    {
        if (txId.Text != null)
        {
            DAODisco.sqlDelete(new Disco(int.Parse(txId.Text)));
            lbMensaje.Text = "Disco eliminado";
        }
        else
            lbMensaje.Text = "No se pudo eliminar el disco";
    }

    public void limpiar()
    {
        foreach (Control c in this.Controls)
        {
            if (c is TextBox)
            {
                ((TextBox)c).Text = "";
            }
        }
    }

    public void artista()
    {
        cbArtista.DataSource = DAOArtista.sqlLeerTodas();
        cbArtista.DataTextField = "nombre";
        cbArtista.DataValueField = "id";
        cbArtista.DataBind();
    }
}
