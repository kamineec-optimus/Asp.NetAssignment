<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Members.aspx.cs" Inherits="LibraryProject.Members" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label><br /><br />
        <asp:GridView ID="gvMembers" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
            <RowStyle BackColor="White" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView><br /> 
         <asp:LinkButton ID="lbtnPrevious" runat="server" style="margin-left: 60px" Width="150px" OnClick="lbtnPrevious_Click" >Back to Previous Page</asp:LinkButton>
        <asp:LinkButton ID="lbtnLogout" runat="server" style="margin-left: 60px" Width="150px" OnClick="lbtnLogout_Click" >LogOut</asp:LinkButton><br /><br /><br /><br />
        <asp:MultiView ID="multiView" ActiveViewIndex="-1" runat="server">
            <asp:View runat="server" ID="View1">
        <asp:Label ID="lblMemberName" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="txtMemberName" runat="server" style="margin-left: 62px" Width="98px"></asp:TextBox><br /><br />
        <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server" style="margin-left: 46px" Width="94px"></asp:TextBox><br /><br />
        <asp:Label ID="RoleId" runat="server" Text="Role Id"></asp:Label>
        <asp:TextBox ID="txtRoleId" runat="server" style="margin-left: 51px" Width="91px"></asp:TextBox><br /><br />
        <asp:Label ID="lblUserName" runat="server" Text="User Name"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" style="margin-left: 27px" Width="94px"></asp:TextBox><br /><br />
        <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" style="margin-left: 38px" Width="94px" TextMode="Password"></asp:TextBox><br /><br />
        <asp:Button ID="btnAddMember" runat="server" Text="Add Members" OnClick="btnAddMember_Click"/>
        </asp:View>
        </asp:MultiView>

    </div>
    </form>
</body>
</html>
