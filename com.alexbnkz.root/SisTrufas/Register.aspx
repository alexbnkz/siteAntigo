<%@ Page Title="" Language="C#" MasterPageFile="~/SisTrufas/Site1.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="com.alexbnkz.root.SisTrufas.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Solicitação de Trufas - Registro de usuário</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
<div id="content">
    
    <article id="large-buttonbar" class="component">
        <header>
            <h2>Sistema de Solicitação de Trufas</h2>
        </header>
         <section>
        <header>
            <h3>Informações de registro</h3>
        </header>         
            <label for="WhatsApp" title="Entre com o seu WhatsApp">Nº WhatsApp</label>
            <input type="number" id="WhatsApp" name="WhatsApp" required="true" value="<%=Request["WhatsApp"] %>" class="topcoat-text-input--large" min="1099999999" max="99999999999" maxlength="11" />  
            <sub style="color: #666;">Apenas números<br />Ex. 21xxxxxxxxx</sub>  

            <label for="Nome" title="Nome">Nome</label>
            <input type="text" id="Nome" name="Nome" required="true" value="<%=Request["Nome"] %>" placeholder="ex: Levi da Silva" class="topcoat-text-input--large" maxlength="50" />    

            <label for="Email" title="Coloque um e-mail">E-mail</label>
            <input type="email" id="Email" name="Email" required="true" value="<%=Request["Email"] %>" placeholder="levi@exemplo.com" class="topcoat-text-input--large" maxlength="100" />     

            <label for="Senha" title="Senha">Senha</label>
            <input type="password" id="Senha" name="Senha" required="true" value="" class="topcoat-text-input--large" maxlength="50" />
            <sub style="color: #666;">mín. 6 caracteres</sub> 

            <label for="SenhaConfirme" title="Confirme a senha">Confirme a senha</label>
            <input type="password" id="SenhaConfirme" name="SenhaConfirme" required="true" value="" class="topcoat-text-input--large" maxlength="50" />  <br />   <br />  

            <asp:Button runat="server" ID="Registrar" OnClick="Registrar_Click" Text="Registrar" CssClass="topcoat-button--large--cta" style="width: 100%; padding: 5px;" /> <br /> <br />
            
        </section>
    </article>
    
</div>
</asp:Content>
