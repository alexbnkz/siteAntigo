using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using com.alexbnkz.Base;

namespace com.alexbnkz.root.SisTrufas.Cadastro
{
    public partial class Default : System.Web.UI.Page
    {
        public string GridTrufas = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (false)
            {
                SisTrufasDataAccess Base = new SisTrufasDataAccess();

                //Response.Write(Base.DropTableTrufas());
                //Response.Write(Base.CreateTableTrufas());

                //Base.IncluirTrufas("Beijinho", "02beijinho", "Trufa com recheio de beijinho de côco.");
                //Base.IncluirTrufas("Dois Amores", "03doisamores", "Trufa com recheio combinado de brigadeiro e beijinho de côco.");
                //Base.IncluirTrufas("Morango", "04morango", "Trufa com recheio de morango.");
                //Base.IncluirTrufas("Maracujá", "05maracuja", "Trufa com recheio de maracujá.");
                //Base.IncluirTrufas("Limão", "06limao", "Trufa com recheio de limão.");
                //Base.IncluirTrufas("Doce de leite", "07docedeleite", "Trufa com recheio de doce de leite.");
                //Base.IncluirTrufas("Doce de leite com ameixa", "08docedeleitecomameixa", "Trufa com recheio de doce de leite com ameixa.");
                //Base.IncluirTrufas("Cereja", "09cereja", "Trufa com recheio de cereja.");
                //Base.IncluirTrufas("Abacaxi", "10abacaxi", "Trufa com recheio de abacaxi.");
                //Base.IncluirTrufas("Amendoim", "11amendoim", "Trufa com recheio de amendoim.");
                //Base.IncluirTrufas("Disqueti com chocolate branco", "12disqueticomchocolatebranco", "Trufa com recheio de disqueti com chocolate branco.");
                //Base.IncluirTrufas("Disqueti com chocolate preto", "13disqueticomchocolatepreto", "Trufa com recheio de disqueti com chocolate preto.");
                //Base.IncluirTrufas("Passas ao rum", "14passasaorum", "Trufa com recheio de passas ao rum.");

                string Recheio = "" + Request.Form["Recheio"];
                string Foto = "" + Request.Form["Foto"];
                string Descricao = "" + Request.Form["Descricao"];

                if (Recheio != "" && Foto != "" && Descricao != "")
                {
                    //Base.IncluirTrufas(Recheio, Foto, Descricao);
                    Response.Redirect("../");
                }
                else
                {
                    Response.Write("Campo deve ser preenchido! <br />");
                }
            }
            else
            {
                Response.Redirect("../");
            }
        }
    }
}