﻿using System;
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

public partial class FrIngresar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btAtrás_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrPrincipal.aspx");
    }
    protected void btIngresar_Click(object sender, EventArgs e)
    {
        BibliotecaMusica.Entity.Usuarios usuario = new BibliotecaMusica.Entity.Usuarios(txUsuario.Text, txClave.Text);
        if (!BibliotecaMusica.DAO.DAOUsuarios.login(usuario))
        {
            lbMensajeIngresar.Text = "Error. Usuario y/o Clave inválido.";
        }
        else
        {
            Session["usuario"] = usuario;
            Response.Redirect("FrBuscador.aspx");
        }
    }
}
