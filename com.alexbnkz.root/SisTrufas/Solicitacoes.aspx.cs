using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using com.alexbnkz.Base;

using System.Security.Cryptography;
using System.Text;

namespace com.alexbnkz.root.SisTrufas
{
    public partial class Solicitacoes : System.Web.UI.Page
    {
        SisTrufasDataAccess Base = new SisTrufasDataAccess();
        public string HTML = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            //string password = "";
            //using (MD5 md5Hash = MD5.Create()) { password = GetMd5Hash(md5Hash, "Android9589"); }
            //Base.AtualizaSenhaUsuario("21969476360", password);

            //Response.Write(Base.DropTableUsuario());
            //Response.Write(Base.CreateTableUsuario());

            //HTML += Base.ListaSolicitacaoTable();
            //HTML += Base.ListaUsuarioTable();

            foreach (DataRow row in Base.ListaSolicitacao().Rows)
            {
                HTML += "<section>";
                HTML += "<header><h3>" + row["WhatsApp"].ToString() + "</h3></header>";
                //HTML += Base.ListaItemSolicitacaoTable(row["ID"].ToString());
                HTML += "</section>";
            }

            //Base.AtualizaPrivilegioUsuario("21985333757", "A");
            //Base.AtualizaPrivilegioUsuario("21969476360", "V");

        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }
    }
}