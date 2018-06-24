using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using com.alexbnkz.Base;

namespace com.alexbnkz.root.SisTrufas
{
    public partial class Default : System.Web.UI.Page
    {
        public SisTrufasDataAccess Base = new SisTrufasDataAccess();
        public string Nome = "";
        public string WhatsApp = "";
        public bool usrLogado = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            DataRow Usuario;

            string logado = "" + Session["logado"];
            #region // if (logado != "ON")
            if (logado != "ON")
            {
                Session["logado"] = "";
                Server.Transfer("~\\SisTrufas\\Login.aspx");
            }
            else
            {
                usrLogado = true;
                WhatsApp = "" + Session["WhatsApp"];

                Usuario = Base.ListaUsuario(WhatsApp).Rows[0];
                Nome = Usuario["Nome"].ToString();

                if ("" + Session["logadoBemVindo"] == "ON")
                {
                    Nome = "Olá, " + Nome;
                    Session["logadoBemVindo"] = "";
                }
            }
            #endregion

        }

        protected void Confirmar_Click(object sender, EventArgs e)
        {
            string IDSolicitacao = Request["IDSolicitacao"].ToString();
            string TipoPagamento = Request["TipoPagamento"].ToString();

            Base.AtualizaPagamentoSolicitacao(IDSolicitacao, TipoPagamento);

            Server.Transfer("~\\SisTrufas\\Finalizar.aspx");

        }
    }
}