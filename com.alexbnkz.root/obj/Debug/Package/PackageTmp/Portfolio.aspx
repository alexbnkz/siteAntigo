<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Portfolio.aspx.cs" Inherits="com.alexbnkz.root.Portfolio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Alex Benincasa - Portfólio</title>
    <meta name="description" content="Meu Portfólio inclui um app em Android. TCC em JAVA. E o layout da Sports Nutrition Center em 2010." />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



 <div class="page-header">
        <h1>Portfólio</h1>
      </div>
      <div class="row">
        <div class="col-sm-4">
        
          <div class="panel panel-default">
            <div class="panel-heading">
              <h3 class="panel-title">App Zélia Trufas</h3>
            </div>
            <div class="panel-body">
            <p><strong>Android / C# / SQLSERVER 2008</strong></p>                   
            <a target="_blank" href="https://play.google.com/store/apps/details?id=com.alexbnkz.zeliatrufas&hl=pt_BR">
                   <img src="img/playStoreZeliaTrufas.png" style="width: 100%;" data-src="holder.js/1108x721" class="img-thumbnail" alt="1108x721" />
                   </a>
            </div>
          </div>
          
          </div><!-- /.col-sm-4 -->
       

         <div class="col-sm-4">

         
          <div class="panel panel-default">
            <div class="panel-heading">
              <h3 class="panel-title">TCC Gerenciador de Experimentos do Lab. de Biotecnologia (GELB)</h3>
            </div>
            <div class="panel-body">
            <p><strong>JAVA / Servlet /  MySQL</strong></p>      
            <a target="_blank" href="img/tccGelb2014.jpg">
                <img src="img/tccGelb2014.jpg" style="width: 100%;" data-src="holder.js/1003x542" class="img-thumbnail" alt="1003x542" />
                </a>
            </div>
          </div>
          </div><!-- /.col-sm-4 -->
       

         <div class="col-sm-4">

           <div class="panel panel-default">
            <div class="panel-heading">
              <h3 class="panel-title">Sports Nutrition Center</h3>
            </div>
            <div class="panel-body">
               <p><strong>ASP / VB / SQLSERVER 2008</strong></p>  
                <a target="_blank" href="img/snc.jpg">
               <img src="img/snc.jpg" style="width: 100%;" data-src="holder.js/1366x768" class="img-thumbnail" alt="1366x768" />
               </a>
            </div>
          </div>
         
        </div><!-- /.col-sm-4 -->
       
      </div>

</asp:Content>
