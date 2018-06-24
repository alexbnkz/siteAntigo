using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Text;
using com.alexbnkz.Base;

namespace com.alexbnkz.root.SisTrufas
{
    public partial class Login : System.Web.UI.Page
    {
        SisTrufasDataAccess Base = new SisTrufasDataAccess();

        protected void Page_Load(object sender, EventArgs e)
        {
            string logado = "" + Session["logado"];
            if (logado == "ON")
            {
                Server.Transfer("~\\SisTrufas\\Default.aspx");
            }

            string cadastradoOk = "" + Session["cadastradoOk"];
            if (cadastradoOk == "Sim")
            {
                ((Site1)this.Master).outMSG("Você foi cadastrado com sucesso!");
            }
            Session["cadastradoOk"] = "";
        }

        protected void LogIn_Click(object sender, EventArgs e)
        {
            string WhatsApp = LimpaWhats("" + Request["WhatsApp"]);
            string Senha = "" + Request["Senha"];

            if (!(WhatsApp == "" || Senha == ""))
            {
                if (Base.ExisteUsuario(WhatsApp))
                {
                    string password = "";
                    using (MD5 md5Hash = MD5.Create()) { password = GetMd5Hash(md5Hash, Senha); }

                    if (Base.AutenticaUsuario(WhatsApp, password))
                    {
                        Session["logado"] = "ON";
                        Session["logadoBemVindo"] = "ON";
                        Session["WhatsApp"] = WhatsApp;
                        Session["Privilegio"] = Base.ListaUsuario(WhatsApp).Rows[0]["Privilegio"].ToString();

                        Server.Transfer("~\\SisTrufas\\Default.aspx");
                    }
                    else
                        ((Site1)this.Master).outERRO("WhatsApp/Senha incorretos!");
                }
                else
                    ((Site1)this.Master).outERRO("WhatsApp não cadastrado!");
            }
            else
                ((Site1)this.Master).outERRO("Preencha corretamente os campos WhatsApp/Senha!");
        }

        protected void Registre_Click(object sender, EventArgs e)
        {
            Server.Transfer("~\\SisTrufas\\Register.aspx");
        }

        private string LimpaWhats(string numero)
        {
            return numero.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
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