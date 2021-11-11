<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Login.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link href="style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
       
            <asp:Label id="lblName" runat="server"  Text="Korisnicko ime" Width="92px"></asp:Label> 
         
            <input id="Username" type="text" runat="server"/>
           
            <br />

            <asp:Label id="lblPass" runat="server"  Text="Lozinka" Width="50px"></asp:Label>
            <input id="Password" type="password"  runat="server"/> 

            <br /><br />

            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />

            <br />

            <asp:Label id="ErrorMessage" runat="server">Krivo upisani podaci</asp:Label>
           
            <br />

            <asp:ListBox ID="txtResults" runat="server"></asp:ListBox>
    </form>
</body>
</html>
