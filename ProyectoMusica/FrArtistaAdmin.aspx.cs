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

public partial class FrArtistaAdmin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btHelp_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrArtista.aspx");
    }
    protected void btLeer_Click(object sender, EventArgs e)
    {
        Artista artista = DAOArtista.sqlLeer(new Artista(int.Parse(txId.Text)));
        if (artista != null)
        {
            txNombre.Text = artista.Nombre;
            txId.Text = artista.Id.ToString();
            LbMensaje.Text = "Datos Seleccionados";
        }
        else
        {
            LbMensaje.Text = "Id incorrecta";
            txNombre.Text = "";

        }
    }
    protected void btAgregar_Click(object sender, EventArgs e)
    {

        //BibliotecaMusica.Entity.Artista artista = new BibliotecaMusica.Entity.Artista(int.Parse(txId.Text), txNombre.Text);
        //if (!BibliotecaMusica.DAO.DAOArtista.sqlInsert(artista))
        //{
        //    LbMensaje.Text = "Error. No se pudo agregar el disco";
        //}
        //else
        //{
        //    LbMensaje.Text = "Artista agregado exitosamente";
        //    Session["id"] = artista;
        //}

        Artista artista = new Artista(int.Parse(txId.Text), txNombre.Text);
        if (!DAOArtista.sqlInsert(artista))
        {
            LbMensaje.Text = "Error. No se pudo agregar el Artista";
        }
        else
        {
            LbMensaje.Text = "Artista agregado exitosamente";
            Session["id"] = artista;
        }
    }
    protected void btActualizar_Click(object sender, EventArgs e)
    {
        Boolean actualizar = DAOArtista.sqlUpdate(new Artista(int.Parse(txId.Text), txNombre.Text));
        LbMensaje.Text = "Datos actualizados";
    }
    protected void btEliminar_Click(object sender, EventArgs e)
    {
        if (txId.Text != null)
        {
            DAOArtista.sqlDelete(new Artista(int.Parse(txId.Text)));
            LbMensaje.Text = "Artista eliminado";
            this.limpiar();
        }
        else
            LbMensaje.Text = "No se pudo eliminar el artista";
    }
    protected void btLimpiar_Click(object sender, EventArgs e)
    {
        //this.limpiar();
        limpiar();
    }

    public void limpiar()
    {
        //foreach (Control c in this.Controls)
        //{
        //    if (c is TextBox)
        //    {
        //       c.Text = "";
        //    }
        //}

        txId.Text = "";
        txNombre.Text = "";

    }
    protected void btCerrar_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrIngresar.aspx");
    }
}
