using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using com.alexbnkz.Base;

namespace com.alexbnkz.root.SisTrufas
{
    public partial class AdmClientes : System.Web.UI.Page
    {
        SisTrufasDataAccess Base = new SisTrufasDataAccess();
        public string HTML = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            //HTML += Base.ListaUsuarioTable();
        }
    }
}