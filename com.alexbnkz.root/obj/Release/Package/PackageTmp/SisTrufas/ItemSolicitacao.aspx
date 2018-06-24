<%@ Page Language="C#" AutoEventWireup="true" EnableEventValidation="true" CodeBehind="ItemSolicitacao.aspx.cs" Inherits="com.alexbnkz.root.SisTrufas.ItemSolicitacao" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta name="viewport" content="user-scalable=no,initial-scale = 1.0,maximum-scale = 1.0" />
    <meta http-equiv="Content-Type" content="text/html;charset=UTF-8" />
    <meta charset="UTF-8" />

    <link rel="stylesheet" type="text/css" href="fonts/stylesheet.css" />
    <link rel="stylesheet" type="text/css" href="css/main.css" />
    <link rel="stylesheet" type="text/css" href="css/brackets.css" />
    <link rel="stylesheet" type="text/css" href="css/topcoat-desktop-dark.css" />
</head>
<body class="dark" style="width: 100%;">
<div style="overflow-x: hidden;">
<div id="wrapper">
    <form id="form1" runat="server">
    <input type="hidden" id="WhatsApp" name="WhatsApp" value="<%=Request["WhatsApp"] %>" />  
                    
    <div>
    <asp:GridView ID="gridItemSolicitacao" AutoGenerateColumns="false" runat="server" Width="100%"> 
        <Columns> 
            <asp:BoundField DataField="NUM" HeaderText="#" ItemStyle-HorizontalAlign="Center" /> 
            <asp:BoundField DataField="Recheio" HeaderText="Recheio" ItemStyle-HorizontalAlign="Center" /> 
            <asp:BoundField DataField="Quantidade" HeaderText="Quantidade" ItemStyle-HorizontalAlign="Center" /> 
            <asp:BoundField DataField="Valor" HeaderText="Valor" ItemStyle-HorizontalAlign="Center" /> 
            <asp:TemplateField ItemStyle-HorizontalAlign="Center">
                <ItemTemplate> 
                    <button type="button" class="topcoat-button--cta" onclick="javascript:excItem(<%# DataBinder.Eval(Container.DataItem, "ID") %>, '<%# DataBinder.Eval(Container.DataItem, "Recheio") %>');">Apagar</button>
                </ItemTemplate> 
            </asp:TemplateField> 
        </Columns> 
    </asp:GridView>
    </div>
    </form>
</div>
</div>
    <script type="text/javascript" src="js/main.js"></script>
    <script type="text/javascript">
        parent.document.getElementById('IDSolicitacao').value = '<%=IDSolicitacao %>';
        parent.document.getElementById('Total').value = '<%=Total %>';
    </script>
</body>
</html>
