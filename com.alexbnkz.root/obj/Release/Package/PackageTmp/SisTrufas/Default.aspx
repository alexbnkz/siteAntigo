<%@ Page Title="" Language="C#" MasterPageFile="~/SisTrufas/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="com.alexbnkz.root.SisTrufas.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Solicitação de Trufas</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
<div id="content">
    
    <article id="large-buttonbar" class="component">
        <header>
            <h2>Sistema de Solicitação de Trufas</h2>
        </header>
        <section>
        <header>
            <h3><%=Nome %> (<%=WhatsApp %>)</h3>
        </header>
            <input type="hidden" id="WhatsApp" name="WhatsApp" value="<%=WhatsApp %>" />  
            <input type="hidden" id="CMD" name="CMD" value="" />
            <input type="hidden" id="IDSolicitacao" name="IDSolicitacao" value="" />

            <label for="Recheio">Trufa com <strong>recheio</strong> de </label> 
            <select id="Recheio" name="Recheio" required="true" class="docNav">
                <%=Base.ListaTrufasCombo() %>
            </select>

            <label for="Quantidade"> Quantidade</label>  
            <input type="number" id="Quantidade" name="Quantidade" required="true" class="topcoat-text-input--large" value="1" placeholder="1" min="1" max="500" maxlength="3"/>  
            <button type="button" class="topcoat-button--large--cta" onclick="javascript:addItem();">ADD</button> <br /> <br />
                   
            <div>
                <iframe id="iframeSolicita" name="iframeSolicita" src="ItemSolicitacao.aspx?WhatsApp=<%=WhatsApp %>" scrolling="auto" style="width: 100%; height: 250px; margin: 5px; border: 1px solid #58595A;"></iframe>
            </div>

            <footer>
                <h3>
                    Total <input type="text" id="Total" name="Total" readonly="true" style="width: 100px; color: #F0F1F1; text-align: right; font-size: inherit; border: none; background: none; float: right;" />  
                </h3>
            </footer>
        </section>
        <section>
        <header>
            <h3>Pagamento</h3>
        </header>
            <label for="TipoPagamento">Forma de Pagamento </label> 
            <select id="TipoPagamento" name="TipoPagamento" required="true" class="docNav">
                <%=Base.ListaPagamentoCombo() %>              
            </select>
            <br /> <br />                         
        </section>
        <section>
        <header>
            <h3>Entrega</h3>
        </header>
        <div>
            <p>
                A Equipe Zélia Trufas, por enquanto, não trabalha com entregas. Peça ajuda ao nosso revendedor mais próximo.
            </p>
                        
            <asp:Button runat="server" ID="Confirmar" OnClick="Confirmar_Click" Text="Confirmar solicitação" CssClass="topcoat-button--large--cta" style="width: 100%; padding: 5px;" /> <br /> <br />
        </div>                        
        </section>

    </article>


</div>
</asp:Content>
