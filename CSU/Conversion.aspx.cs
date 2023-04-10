using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ejercicioWebServices.CSD;

namespace ejercicioWebServices.CSU
{
    public partial class Conversion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Convertir oconvertir = new Convertir();
            TxtResultado.Text = oconvertir.numeroaletras(ulong.Parse(txtnumero.Text));
        }

        protected void btnDolars_Click(object sender, EventArgs e)
        {
            Convertir oconvetir = new Convertir();
            TxtResultado.Text = oconvetir.numeroaDolares(decimal.Parse(txtnumero.Text));
        }
    }
}