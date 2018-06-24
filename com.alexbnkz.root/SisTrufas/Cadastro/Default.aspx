<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="com.alexbnkz.root.SisTrufas.Cadastro.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <label for="Recheio">Recheio</label>
        <input type="text" id="Recheio" name="Recheio" />
    </div>
    <div>
        <label for="Foto">Foto</label>
        <input type="text" id="Foto" name="Foto" />
    </div>
    <div>
        <label for="Descricao">Descrição</label><br />
        <textarea id="Descricao" name="Descricao" rows="8" style="width: 200px;"></textarea>
    </div>
    <div>
        <input type="submit" value="Salvar" />
    </div>
    </form>

    <div>
    <%=GridTrufas %>
    </div>

</body>
</html>
