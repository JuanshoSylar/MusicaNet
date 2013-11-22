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

public partial class FrUsuarioAdmin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btLeer_Click(object sender, EventArgs e)
    {
        if (txUsuario.Text.Equals(""))
        {
            lbMensaje.Text = "Ingrese un nombre de usuario para continuar.";
            return;
        }

        Usuarios usuario = DAOUsuarios.sqlLeer(new Usuarios(txUsuario.Text));

        if (usuario != null)
        {
            txClave.Text = usuario.Clave;
            txEsAdmin.Text = usuario.EsAdmin.ToString();
            lbMensaje.Text = "Dato seleccionado";
        }
        else
        {
            lbMensaje.Text = "Error. Usuario no válido.";
            txClave.Text = "";
            txEsAdmin.Text = "";
        }
    }

    public Boolean validar()
    {
        if (txUsuario.Text.Equals(""))
        {
            lbMensaje.Text = "Error. Debe escribir un usuario";
            return false;
        }
        else if (txClave.Text.Equals(""))
        {
            lbMensaje.Text = "Error. Debe escribir una clave";
            return false;
        }
        else if (txEsAdmin.Text.Equals(""))
        {
            lbMensaje.Text = "Error. Debe escribir si es o no admin";
            return false;
        }
        else
            return true;
    }
    protected void btActualizar_Click(object sender, EventArgs e)
    {
        if (validar())
        {
            Boolean actualiza = DAOUsuarios.sqlUpdate(new Usuarios(txUsuario.Text, txClave.Text, int.Parse(txEsAdmin.Text)));
            lbMensaje.Text = "Dato actualizado exitosamente";
        }
    }
    protected void btDesplegar_Click(object sender, EventArgs e)
    {
        if (btDesplegar.Text == "v")
        {
            grUsuarios.Visible = true;
            DataTable dt = DAOUsuarios.sqlLeerTodas();
            grUsuarios.DataSource = dt;
            grUsuarios.DataBind();
            btDesplegar.Text = "^";
        }
        else if (btDesplegar.Text == "^")
        {
            grUsuarios.Visible = false;
            btDesplegar.Text = "v";
        }
    }
    protected void btEliminar_Click(object sender, EventArgs e)
    {
        if (txUsuario.Text.Equals(""))
        {
            lbMensaje.Text = "Debe escribir un usuario";
            return;
        }

        if (DAOUsuarios.sqlDelete(new Usuarios(txUsuario.Text)))
            lbMensaje.Text = "Usuario eliminado";
        else
            lbMensaje.Text = "No existe en la base de datos";
    }
    protected void btAtras_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrAdministrar.aspx");
    }
}
