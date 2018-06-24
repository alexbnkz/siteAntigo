<%@ Page Title="" Language="C#" MasterPageFile="~/SisTrufas/Site1.Master" AutoEventWireup="true" CodeBehind="PagSeguro.aspx.cs" Inherits="com.alexbnkz.root.SisTrufas.PagSeguro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Solicitação de Trufas - PagSeguro</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
<div id="content">
    <input type="hidden" id="CMD" name="CMD" value="" />
    <input type="hidden" id="IDSolicitacao" name="IDSolicitacao" value="" />

    <article id="large-buttonbar" class="component">
        <header>
            <h2>Sistema de Solicitação de Trufas</h2>
        </header>
        <section>
        <header>
            <h3>PagSeguro</h3>
        </header>
        
        <div class="finaliza">
        <div><strong>Nome</strong> xxx</div>
        <div><strong>WhatsApp</strong> xxx</div>
        <div><strong>E-mail</strong> xxx</div>

        <div>
            <asp:GridView ID="gridItemSolicitacao" AutoGenerateColumns="false" runat="server" Width="100%"> 
                <Columns> 
                    <asp:BoundField DataField="NUM" HeaderText="#" ItemStyle-HorizontalAlign="Center" /> 
                    <asp:BoundField DataField="Recheio" HeaderText="Recheio" ItemStyle-HorizontalAlign="Center" /> 
                    <asp:BoundField DataField="Quantidade" HeaderText="Quantidade" ItemStyle-HorizontalAlign="Center" /> 
                    <asp:BoundField DataField="Valor" HeaderText="Valor" ItemStyle-HorizontalAlign="Center" /> 
                </Columns> 
            </asp:GridView>
        </div>

        <div><strong>Total</strong> xxxx</div>
        <div><strong>Pagamento</strong> <%=Request["TipoPagamento"] %></div>
        </div>

        </section>
        <section>
        <header>
            <h3>Entrega</h3>
        </header>
        <div>
            <p>
                A Equipe Zélia Trufas, por enquanto, não trabalha com entregas. Peça ajuda ao nosso revendedor mais próximo.
            </p>
                        
            <asp:Button runat="server" ID="FinalizaSolic" Text="Finalizar" CssClass="topcoat-button--large--cta" style="width: 100%; padding: 5px;" /> <br /> <br />
        </div>                        
        </section>
        <br />
    </article>


</div></asp:Content>
