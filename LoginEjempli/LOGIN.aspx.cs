using LoginEjempli.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginEjempli
{
    public partial class LOGIN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Bagregar_Click(object sender, EventArgs e)
        {
            Clases.usuario objUsuarios = new Clases.usuario(Tcorreo.Text,Tclave.Text);
            if (usuario.ValidarLogin() > 0)
            {
                Response.Redirect("pagi2.aspx");

            }    

        }
    }
}