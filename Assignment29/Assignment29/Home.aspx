<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Assignment29.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblName" runat="server" Text="Student Name"></asp:Label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox><br /><br />
        <asp:Label ID="lblAge" runat="server" Text="Student Age"></asp:Label>
        <asp:TextBox ID="txtAge" runat="server"></asp:TextBox><br /><br />
        <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox><br /><br />


        <asp:Button ID="btnAddNode" runat="server" Text="Add Node" OnClick="btnAddNode_Click" />
    </div>
    </form>
</body>
</html>
