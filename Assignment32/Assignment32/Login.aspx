<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Assignment32.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblUserName" runat="server" Text="UserName"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox><br /><br />
        <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox><br /><br />
        <asp:Button ID="BtnLogin" runat="server" Text="Login" OnClick="BtnLogin_Click" /><br /><br />
         <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
    </div>
       
    </form>
</body>
</html>
