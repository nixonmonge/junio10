<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebListar.aspx.cs" Inherits="Junio10.WebListar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="401px">
                <Columns>
                    <asp:BoundField DataField="Pais.PaisNombre" HeaderText="Pais" />
                    <asp:BoundField DataField="Fecha" HeaderText="Fecha" />
                    <asp:BoundField DataField="WeatherId" HeaderText="Id Clima" />
                    <asp:BoundField DataField="Estado.Nombre" HeaderText="Estado" />
                    <asp:TemplateField>
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Image ID="Image1" runat="server" Height="24px" ImageUrl='<%# Eval("Estado.Nombre","png/{0}.png") %>' Width="31px" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
    <a href="WebInsertar.aspx"> Ur a Insertar</a>
</body>
</html>
