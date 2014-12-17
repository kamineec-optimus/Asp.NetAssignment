<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="LibraryProject.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label><br /><br />
        <asp:LinkButton ID="lbtnBooks" runat="server" PostBackUrl="~/LibBooks.aspx">Books</asp:LinkButton><br /><br />        
        <asp:LinkButton ID="lbtnMembers" runat="server" PostBackUrl="~/Members.aspx">Members</asp:LinkButton><br /><br />   
        <asp:LinkButton ID="lbtnPrevious" runat="server" OnClick="lbtnPrevious_Click" >Back to Previous Page</asp:LinkButton>
        <asp:LinkButton ID="lbtnLogout" runat="server" style="margin-left: 60px" Width="150px" OnClick="lbtnLogout_Click" >LogOut</asp:LinkButton><br /><br />

      
      </div>
    </form>
</body>
</html>
