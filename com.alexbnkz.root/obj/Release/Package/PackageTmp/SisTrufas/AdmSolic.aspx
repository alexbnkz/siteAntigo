﻿<%@ Page Title="" Language="C#" MasterPageFile="~/SisTrufas/Site1.Master" AutoEventWireup="true" CodeBehind="AdmSolic.aspx.cs" Inherits="com.alexbnkz.root.SisTrufas.AdmSolic" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <title>Solicitação de Trufas - Administração - Solicitações</title>
     <style type="text/css">
         .grid 
         {
             text-align: center;
             border-bottom: 1px solid #58595A;
             display: inline-block;
         }
         .grid .row 
         {
             width: 100%;
             display: inline-block;
             padding: 5px 5px 5px 10px; 
         }
         .grid .row div
         {
             text-align: center;
             display: table-cell;
         }
     </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
<div id="content">
    <input type="hidden" id="CMD" name="CMD" value="" />
    <input type="hidden" id="IDSolicitacao" name="IDSolicitacao" value="" />

    <article id="large-buttonbar" class="component">
        <header>
            <h2>Administração</h2>
        </header>
        <section>
        <header>
            <h3>Solicitações</h3>
        </header>
        
            
        
        </section>
        <br />
    </article>


</div>
</asp:Content>
