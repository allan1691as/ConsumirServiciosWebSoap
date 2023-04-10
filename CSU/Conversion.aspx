<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Conversion.aspx.cs" Inherits="ejercicioWebServices.CSU.Conversion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       
        <asp:Label ID="Label1" runat="server" Text="Numero: "></asp:Label>
       
        <asp:TextBox ID="txtnumero" runat="server" Width="191px"></asp:TextBox>
       
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="A letras" OnClick="Button1_Click" />
       
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDolars" runat="server" Text="A Dolares" OnClick="btnDolars_Click" />
       
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Resultado"></asp:Label>
       
    &nbsp;
        <asp:TextBox ID="TxtResultado" runat="server"></asp:TextBox>
       
    </form>
</body>
</html>
