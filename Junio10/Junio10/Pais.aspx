<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pais.aspx.cs" Inherits="Junio10.Pais" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:TextBox ID="PaisId" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:TextBox ID="PaisNombre" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
