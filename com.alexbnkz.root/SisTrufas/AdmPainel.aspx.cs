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
    public partial class AdmPainel : System.Web.UI.Page
    {
        SisTrufasDataAccess Base = new SisTrufasDataAccess();
        public string HTML = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if ("" + Request["CMD"] == "PAGO")
            {
                string IDSolicitacao = Request["IDSolicitacao"];
                Base.AtualizaPagoOkSolicitacao(IDSolicitacao);
            }

            if ("" + Request["CMD"] == "CANCELAR")
            {
                string IDSolicitacao = Request["IDSolicitacao"];
                Base.CancelarSolicitacao(IDSolicitacao);
            }
            
            ListaPendentes();

            Response.Write("<br />" + Base.execSQL("ALTER TABLE stSolicitacao ADD Cancelado varchar() NOT NULL DEFAULT 0;"));
            //Response.Write("<br />" + Base.execSQL("ALTER TABLE stSolicitacao ADD Cancelado int NOT NULL DEFAULT 0;"));
            //Response.Write("<br />" + Base.execSQL("UPDATE stSolicitacao SET Cancelado = 0;"));

            //Response.Write("<br />" + Base.execSQL("DELETE FROM stItemSolicitacao WHERE IdSolicitacao = 13 OR IdSolicitacao = 14 OR IdSolicitacao = 15;"));
            //Response.Write("<br />" + Base.execSQL("DELETE FROM stSolicitacao WHERE ID = 13 OR ID = 14 OR ID = 15;"));

            //Response.Write("<br />" + Base.execSQL("UPDATE stSolicitacao SET Total = 6 WHERE ID = 2;"));


            //Response.Write(Base.CreateTablePagamento());
            //Response.Write(Base.IncluirPagamento("Dinheiro (Alex, INCA)"));
            //Response.Write(Base.IncluirPagamento("PagSeguro"));
        }

        protected void ListaPendentes()
        {
            try
            {
                DataTable SolicitacaoPendente = Base.ListaSolicitacaoPendente();

                if (SolicitacaoPendente.Rows.Count > 0)
                {
                    foreach (DataRow Solic in SolicitacaoPendente.Rows)
                    {
                        if (Base.ListaUsuario(Solic["WhatsApp"].ToString()).Rows.Count > 0)
                        {
                            DataRow Usuario = Base.ListaUsuario(Solic["WhatsApp"].ToString()).Rows[0];
                            string Nome = Usuario["Nome"].ToString();

                            if (Nome.Split(' ').Length >= 2) Nome = Nome.Split(' ')[0] + " " + Nome.Split(' ')[1];

                            HTML += "<section>";
                            HTML += "<header><h3>" + Nome + ", " + Solic["Data"].ToString().Split(' ')[0] + "</h3>";
                            HTML += "<button type='submit' onclick='javascript:pagoOkSolic(" + Solic["ID"] + ");' class='topcoat-button--cta' style='float: right;'>Pago</button>";
                            HTML += "<button type='submit' onclick='javascript:cancelarSolic(" + Solic["ID"] + ");' class='topcoat-button' style='float: left;'>Cancelar</button>";
                            HTML += "</header>";

                            HTML += "\n<div class='grid'>";
                            HTML += "\n<div class='row'>";
                            HTML += "\n  <div style='width:30px;font-size: 14px;'>#</div>";
                            HTML += "\n  <div style='width:120px;font-size: 14px;'>Recheio</div>";
                            HTML += "\n  <div style='width:100px;font-size: 14px;'>Quantidade</div>";
                            HTML += "\n</div>";
                            foreach (DataRow Item in Base.ListaItemSolicitacao(Solic["ID"].ToString()).Rows)
                            {
                                HTML += "\n<div class='row'>";
                                HTML += "\n  <div style='width:30px;'>" + Item["NUM"] + "</div>";
                                HTML += "\n  <div style='width:120px;'>" + Item["Recheio"] + "</div>";
                                HTML += "\n  <div style='width:100px;'>" + Item["Quantidade"] + "</div>";
                                HTML += "\n</div>";
                            }
                            HTML += "</div>";

                            HTML += "\n<strong style='font-size: 14px;'>Total <input type='text' name='Total' value='" + Solic["Total"] + "' readonly='true' style='width: 100px; color: #F0F1F1; text-align: right; font-size: inherit; border: none; background: none; float: right;' /></strong>";
                            HTML += "</section>";
                        }
                    }
                }
                else
                {
                    HTML = "<div>Nenhuma solicitação pendente!</div>";
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}