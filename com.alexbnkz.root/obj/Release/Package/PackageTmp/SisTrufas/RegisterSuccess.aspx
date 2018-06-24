<%@ Page Title="" Language="C#" MasterPageFile="~/SisTrufas/Site1.Master" AutoEventWireup="true" CodeBehind="RegisterSuccess.aspx.cs" Inherits="com.alexbnkz.root.SisTrufas.RegisterSuccess" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Solicitação de Trufas - Registrado com sucesso</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
<div id="content">
    
    <article id="large-buttonbar" class="component">
        <header>
            <h2>Sistema de Solicitação de Trufas</h2>
        </header>
         <section>
        <header>
            <h3>Registrado com sucesso!</h3>
        </header>         
            <label title="WhatsApp">Nº WhatsApp</label>
            <input type="text" readonly="true" style="width: 100%; padding-left: 10px; color: #F0F1F1; font-size: inherit; border: none; background: none;" value="<%=Request["WhatsApp"] %>" />   

            <label title="Nome">Nome</label>
            <input type="text" readonly="true" style="width: 100%; padding-left: 10px; color: #F0F1F1; font-size: inherit; border: none; background: none;" value="<%=Request["Nome"] %>" />   

            <label title="Coloque um e-mail">E-mail</label>
            <input type="text" readonly="true" style="width: 100%; padding-left: 10px; color: #F0F1F1; font-size: inherit; border: none; background: none;" value="<%=Request["Email"] %>" />   <br /> <br />

            <asp:Button runat="server" ID="Login" OnClick="Login_Click" Text="Fazer login" CssClass="topcoat-button--large--cta" style="width: 100%; padding: 5px;" /> <br /> <br />
        </section>
    </article>
    
</div>
</asp:Content>
