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
    public partial class Register : System.Web.UI.Page
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

        protected void Registrar_Click(object sender, EventArgs e)
        {
            string WhatsApp = LimpaWhats("" + Request["WhatsApp"]);
            string Nome = "" + Request["Nome"];
            string Email = "" + Request["Email"];
            string Senha = "" + Request["Senha"];
            string SenhaConfirme = "" + Request["SenhaConfirme"];

            string erro = "";
            bool wOk = true;

            if (wOk && WhatsApp == "") { erro = "Corrigir campo WhatsApp!"; wOk = false; }
            if (wOk && WhatsApp.Length < 10) { erro = "Corrigir campo WhatsApp!"; wOk = false; }
            if (wOk && Nome == "") { erro = "Corrigir campo Nome!"; wOk = false; }
            if (wOk && Nome.Length < 3) { erro = "Nome deve ser maior!"; wOk = false; }
            if (wOk && Email == "") { erro = "Corrigir campo E-mail!"; wOk = false; }
            if (wOk && Email.Length < 7) { erro = "Email deve ser maior!"; wOk = false; }
            if (wOk && Senha == "") { erro = "Corrigir campo Senha!"; wOk = false; }
            if (wOk && Senha.Length < 6) { erro = "Senha deve ser maior!"; wOk = false; }
            if (wOk && Senha != SenhaConfirme) { erro = "Senha e Confirmar senha não conferem!"; wOk = false; }

            if (wOk)
            {
                if (!Base.ExisteUsuario(WhatsApp))
                {
                    string password = "";
                    using (MD5 md5Hash = MD5.Create()) { password = GetMd5Hash(md5Hash, Senha); }

                    Base.IncluirUsuario(WhatsApp, Nome, Email, password);

                    Session["cadastradoOk"] = "Sim";
                    Server.Transfer("~\\SisTrufas\\RegisterSuccess.aspx?WhatsApp=" + WhatsApp + "&Nome=" + Nome + "&Email=" + Email);
                }
                else
                    ((Site1)this.Master).outERRO("Esse usuário já existe!");
                
            }
            else
                ((Site1)this.Master).outERRO(erro);

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