<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormularioCarga.aspx.cs" Inherits="Clase2.FormularioCarga" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Atras" />
            <br />
            NombreUsuario <asp:TextBox ID="TextBox1" runat="server" required="true"></asp:TextBox>
            <br />
            FechaNacimiento
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Date" required="true"></asp:TextBox>
            <br />
            Comentario
            <asp:TextBox ID="TextBox3" runat="server" Height="75px" TextMode="MultiLine" Width="304px"></asp:TextBox>
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Cargar" />
        </div>
    </form>
</body>
</html>
