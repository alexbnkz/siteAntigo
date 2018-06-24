using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using com.alexbnkz.Base;

namespace com.alexbnkz.root.SisTrufas
{
    public partial class Solicita : System.Web.UI.Page
    {
        public SisTrufasDataAccess Base = new SisTrufasDataAccess();

        protected void Page_Load(object sender, EventArgs e)
        {
            //var lista = Base.ListaSolicitacao();
            //if (lista != null && lista.Rows.Count > 0)
            //{
            //    this.grdDados.DataSource = lista;
            //    this.grdDados.DataBind();
            //}

            //Response.Write(Base.DropTableSolicitacao());
            //Response.Write(Base.CreateTableSolicitacao());
            //Response.Write(Base.DropTableItemSolicitacao());
            //Response.Write(Base.CreateTableItemSolicitacao());
            
            //Response.Write(Base.ListaSolicitacaoTable());

            //Response.Write(Base.ListaItemSolicitacaoTable("1"));

            //Response.Write(Base.IncluirSolicitacao("21969476360", "0", "0"));

            //string[] phone = { "21992000936", "21985333757", "21995891097", "21969476360" };
            //string[] code = { "334537", "791962", "111336", "417385" };

            //int i = 3;

            //string identity = WhatsAppApi.Register.WhatsRegisterV2.GenerateIdentity("55" + phone[i], "Android9589");
            //string response = "";

            //Response.Write("<br /><br /> identity=" + identity);

            //Response.Write("<br /><br /> password=" + WhatsAppApi.Register.WhatsRegisterV2.RegisterCode("55" + phone[i], code[i], out response, identity));
        }
    }
}