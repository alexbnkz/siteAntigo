using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using com.alexbnkz.Base;

namespace com.alexbnkz.root.SisTrufas
{
    public partial class RegisterSuccess : System.Web.UI.Page
    {
        SisTrufasDataAccess Base = new SisTrufasDataAccess();

        protected void Page_Load(object sender, EventArgs e)
        {
            string logado = "" + Session["logado"];
            #region // if (logado != "ON")
            if (logado == "ON")
            {
                Server.Transfer("~\\SisTrufas\\Default.aspx");
            }
            #endregion
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            Server.Transfer("~\\SisTrufas\\Login.aspx");
        }

    }
}