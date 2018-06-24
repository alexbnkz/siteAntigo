using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace com.alexbnkz.root.SisTrufas
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        // ========== CLIENTE ========== //
        protected void Home_Click(object sender, EventArgs e)
        {
            Server.Transfer("~\\SisTrufas\\Default.aspx");
        }

        protected void MinhasSolicitacoes_Click(object sender, EventArgs e)
        {
            Server.Transfer("~\\SisTrufas\\MinhasSolicitacoes.aspx");
        }
        protected void Conta_Click(object sender, EventArgs e)
        {
            //Server.Transfer("~\\SisTrufas\\Conta.aspx");
        }

        protected void Ajuda_Click(object sender, EventArgs e)
        {
            Server.Transfer("~\\SisTrufas\\Ajuda.aspx");
        }
        protected void LogOut_Click(object sender, EventArgs e)
        {
            Session["logado"] = "";
            Server.Transfer("~\\SisTrufas\\Default.aspx");
        }


        // ========== ADMINISTRAÇÃO ========== //
        protected void AdmPainel_Click(object sender, EventArgs e)
        {
            Server.Transfer("~\\SisTrufas\\AdmPainel.aspx");
        }
        protected void AdmSolic_Click(object sender, EventArgs e)
        {
            Server.Transfer("~\\SisTrufas\\AdmSolic.aspx");
        }
        protected void Adm_Click(object sender, EventArgs e)
        {
            Server.Transfer("~\\SisTrufas\\Solicitacoes.aspx");
        }
        protected void AdmCli_Click(object sender, EventArgs e)
        {
            Server.Transfer("~\\SisTrufas\\AdmClientes.aspx");
        }


        #region // funcções outErro e outMSG
        public void outERRO(string msg)
        {
            errOUT.InnerText = msg;
            errOUT.Style.Add("display", "block");
        }
        public void outMSG(string msg)
        {
            msgOUT.InnerText = msg;
            msgOUT.Style.Add("display", "block");
        }
        public void outERRO(string[] msg)
        {
            string text = "";
            foreach (var str in msg)
            {
                text += str + "<br />";
            }

            errOUT.InnerHtml = text;
            errOUT.Style.Add("display", "block");
        }
        public void outMSG(string[] msg)
        {
            string text = "";
            foreach (var str in msg)
            {
                text += str + "<br />";
            }

            msgOUT.InnerText = text;
            msgOUT.Style.Add("display", "block");
        }
        #endregion
    }
}