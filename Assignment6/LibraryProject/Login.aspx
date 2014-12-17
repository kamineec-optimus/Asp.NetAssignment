<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LibraryProject.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">        
    <div>        
        <asp:Label ID="lblUserName" runat="server" Text="User Name"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" style="margin-left: 29px" Width="91px"></asp:TextBox><br /><br />
        <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="txtPassword"  TextMode="Password" runat="server" style="margin-left: 38px" Width="94px"></asp:TextBox><br /><br />
        <asp:Button ID="btnLogin" runat="server" Text="Login" style="margin-left: 73px" Width="60px" OnClick="btnLogin_Click"/>
        <br /><br />
        <asp:Label ID="lblmsg" runat="server" Text=" "></asp:Label>
    </div>
    </form>
</body>
</html>
