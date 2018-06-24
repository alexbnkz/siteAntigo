<%@ Page Title="" Language="C#" MasterPageFile="~/SisTrufas/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="com.alexbnkz.root.SisTrufas.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Solicitação de Trufas - Login</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
<div id="content">
    
    <article id="large-buttonbar" class="component">
        <header>
            <h2>Sistema de Solicitação de Trufas</h2>
        </header>
        <section>
        <header>
            <h3>Login</h3>
        </header>         
            <label for="WhatsApp" title="Entre com o seu WhatsApp">Nº WhatsApp</label>
            <input type="number" id="WhatsApp" name="WhatsApp" required="true" value="" class="topcoat-text-input--large" min="1099999999" max="99999999999" maxlength="11" />  
            <sub style="color: #666;">Apenas números<br />Ex. 21xxxxxxxxx</sub>  

            <label for="Senha" title="Senha">Senha</label>
            <input type="password" id="Senha" name="Senha" required="true" value="" class="topcoat-text-input--large" maxlength="50" />  <br /> <br /> 

            <asp:Button runat="server" ID="LogIn" OnClick="LogIn_Click" Text="Entrar" class="topcoat-button--large--cta" style="width: 100%; padding: 5px;" /> <br /> <br />

            Se você ainda não tem login, <asp:LinkButton runat="server" ID="Registre" OnClick="Registre_Click"><strong>registre-se</strong></asp:LinkButton>! <br /> <br />
            
        </section>
    </article>

    
</div>
</asp:Content>
