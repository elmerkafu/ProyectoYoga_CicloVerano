﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWEB_MatriculaGUI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {

                // Usuario y password obligatorios
                if (txtUsuario.Text.Trim() == String.Empty)
                {
                    throw new Exception("Debe ingresar el usuario.");
                }

                if (txtPassword.Text.Trim() == String.Empty)
                {
                    throw new Exception("Debe ingresar el password.");
                }


                // Validamos el usuario y contraseña

                if (txtUsuario.Text.Trim() == "dCaja" & txtPassword.Text.Trim() == "54321")
                {
                    Response.Redirect("MenuPrincipal.aspx");
                }
                else
                {
                    throw new Exception("Usuario o password errados.");
                }

            }
            catch (Exception ex)
            {
               
            }
        }
    }
}