using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using com.alexbnkz.Base;

namespace com.alexbnkz.root.TrackLoWay
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TrackLoWayDataAccess Base = new TrackLoWayDataAccess();

            //Response.Write(Base.DropTableCoordenadas());
            //Response.Write(Base.CreateTableCoordenadas());
            
            Response.Write(Base.ListaCoordenadas());
        }
    }
}