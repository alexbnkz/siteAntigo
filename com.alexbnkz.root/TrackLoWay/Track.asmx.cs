using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using com.alexbnkz.Base;

namespace com.alexbnkz.root.TrackLoWay
{
    /// <summary>
    /// Summary description for Track
    /// </summary>
    [WebService(Namespace = "http://alexbnkz.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Track : System.Web.Services.WebService
    {
        TrackLoWayDataAccess Base = new TrackLoWayDataAccess();

        [WebMethod]
        public string SalvarCoordenadas(string Email, string Latitude, string Longitude, string Local)
        {
            return Base.SalvarCoordenadas(Email, Latitude, Longitude, Local);
        }
    }
}
