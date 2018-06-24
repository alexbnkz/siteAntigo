using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using com.alexbnkz.Base;

namespace com.alexbnkz.root.SisTrufas
{
    /// <summary>
    /// Summary description for wsTrufas
    /// </summary>
    [WebService(Namespace = "http://alexbnkz.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class wsTrufas : System.Web.Services.WebService
    {
        SisTrufasDataAccess Base = new SisTrufasDataAccess();

        [WebMethod]
        public bool ExisteSolicitacao(string WhatsApp)
        {
            return Base.ExisteSolicitacao(WhatsApp);
        }
    }
}
