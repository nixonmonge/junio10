<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebInsertar.aspx.cs" Inherits="Junio10.WebInsertar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">    
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextWeatherId" runat="server">001</asp:TextBox><br />
            <asp:TextBox ID="TextFecha" runat="server">Fecha</asp:TextBox><br />
            <asp:TextBox ID="TextEstado" runat="server">Estado</asp:TextBox><br />
            <asp:TextBox ID="TextLugar" runat="server">Lugar</asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="Enviar" OnClick="Button1_Click" CssClass="btn btn-success" />
        </div>
    </form>
</body>
</html>
