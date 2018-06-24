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
    public partial class MinhasSolicitacoes : System.Web.UI.Page
    {
        public SisTrufasDataAccess Base = new SisTrufasDataAccess();
        public string HTML = "";
        public string WhatsApp = "";
        public bool usrLogado = false;

        protected void Page_Load(object sender, EventArgs e)
        {
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
            }
            #endregion

            if (usrLogado)
            {
                ListaSolicitacaoCliente(WhatsApp);
            }
        }

        protected void ListaSolicitacaoCliente(string WhatsApp)
        {
            try
            {
                DataTable ListaSolicitacaoCliente = Base.ListaSolicitacaoCliente(WhatsApp);

                if (ListaSolicitacaoCliente.Rows.Count > 0)
                {
                    foreach (DataRow Solic in ListaSolicitacaoCliente.Rows)
                    {
                        if (Base.ListaUsuario(Solic["WhatsApp"].ToString()).Rows.Count > 0)
                        {
                            DataRow Usuario = Base.ListaUsuario(Solic["WhatsApp"].ToString()).Rows[0];
                            string Nome = Usuario["Nome"].ToString();

                            if (Nome.Split(' ').Length >= 2) Nome = Nome.Split(' ')[0] + " " + Nome.Split(' ')[1];

                            HTML += "<section>";
                            HTML += "<header><h3>(" + Solic["ID"] + ") " + Nome + ", " + Solic["Data"].ToString().Split(' ')[0] + "</h3>";
                            HTML += "<button type='submit' onclick='javascript:cancelarSolic(" + Solic["ID"] + ");' class='topcoat-button' style='float: right;'>Cancelar</button>";
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
                    HTML = "<div>Nenhuma solicitação!</div>";
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}