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
    public partial class Finalizar : System.Web.UI.Page
    {
        public SisTrufasDataAccess Base = new SisTrufasDataAccess();
        public DataRow Usuario;
        public DataRow Solicitacao;
        public DataRow Pagamento;

        protected void Page_Load(object sender, EventArgs e)
        {
            string WhatsApp = Session["WhatsApp"].ToString();

            if (Base.ExisteSolicitacao(WhatsApp))
            {
                Usuario = Base.ListaUsuario(WhatsApp).Rows[0];
                Solicitacao = Base.ListaSolicitacao(WhatsApp).Rows[0];
                Pagamento = Base.ListaPagamento(Solicitacao["TipoPagamento"].ToString()).Rows[0];

                this.gridItemSolicitacao.DataSource = Base.ListaItemSolicitacao(Solicitacao["ID"].ToString());
                this.gridItemSolicitacao.DataBind();
            }
            else
            {
                Server.Transfer("~\\SisTrufas\\MinhasSolicitacoes.aspx");
            }
        }

        protected void FinalizaSolic_Click(object sender, EventArgs e)
        {
            Base.FinalizarSolicitacao(Solicitacao["ID"].ToString());
        }

    }
}