using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto2
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //invocar 
            mostrarMensaje();
        }
        public void mostrarMensaje() 
        { 
            Car car = new Car();
            string msj = car.stop();
            lblMensaje.Text = msj;
        }
    }
}