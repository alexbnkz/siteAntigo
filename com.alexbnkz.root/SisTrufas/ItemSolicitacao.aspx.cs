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
    public partial class ItemSolicitacao : System.Web.UI.Page
    {
        public SisTrufasDataAccess Base = new SisTrufasDataAccess();
        public Decimal Total = 0;
        public string IDSolicitacao = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            string WhatsApp = LimpaWhats("" + Request["WhatsApp"]);

            if (WhatsApp != "")
            {
                IDSolicitacao = CreateOrSelectIDSolicitacao(WhatsApp);
                string CMD = "" + Request["CMD"];

                if (CMD == "INCLUIR")
                {
                    string IDTrufa = "" + Request["Recheio"];
                    string Quantidade = "" + Request["Quantidade"];
                    Base.IncluirItemSolicitacao(IDSolicitacao, IDTrufa, Quantidade);
                }

                if (CMD == "DELETAR")
                {
                    string ID = "" + Request["ID"];
                    Base.DeletarItemSolicitacao(ID);
                }

                DataTable tabela = Base.ListaItemSolicitacao(IDSolicitacao);

                if (Base.ExisteItemSolicitacao(IDSolicitacao))
                {
                    this.gridItemSolicitacao.DataSource = tabela;
                    this.gridItemSolicitacao.DataBind();

                    Total = 0;

                    foreach (DataRow row in tabela.Rows)
                    {
                        Total += Convert.ToDecimal("0" + row["Valor"]);
                    }

                    Base.AtualizaTotalSolicitacao(IDSolicitacao, Total.ToString().Replace(",", "."));
                }
                else
                {
                    Response.Write("Adicione uma trufa!");
                }
            }
        }

        protected string CreateOrSelectIDSolicitacao(string WhatsApp)
        {
            if (!Base.ExisteSolicitacao(WhatsApp))
            {
                Base.IncluirSolicitacao(WhatsApp, "0", "0");
            }

            return Base.ListaSolicitacao(WhatsApp).Rows[0]["ID"].ToString(); 
        }

        private string LimpaWhats(string numero)
        {
            return numero.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
        }
    }
}