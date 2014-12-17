<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LibBooks.aspx.cs" Inherits="LibraryProject.LibBooks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label><br /><br />
        <asp:GridView ID="gvBooks" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView><br />
        <asp:Button ID="btnIssueReturnBook" runat="server" Text="Issue/Return BLibraryBook" OnClick="btnIssueReturnBook_Click" />
          <asp:Button ID="btnAddBooks" runat="server" Text="Add BLibraryBook To Library" OnClick="btnAddBooks_Click" style="margin-left: 60px" Visible="False" Width="129px"  />
     
        <asp:Button ID="btnShowIssuedBooks" runat="server" Text="Show Issued Books" style="margin-left: 60px" Width="129px" OnClick="btnShowIssuedBooks_Click"  />
        
        <asp:LinkButton ID="lbtnPrevious" style="margin-left: 60px" Width="150px" runat="server" OnClick="lbtnPrevious_Click" >Back to Previous Page</asp:LinkButton>
        <asp:LinkButton ID="lbtnLogout" runat="server" style="margin-left: 60px" Width="150px" OnClick="lbtnLogout_Click" >LogOut</asp:LinkButton><br /><br /><br /><br />
        <asp:MultiView ID="multiView" ActiveViewIndex="-1" runat="server">
        <asp:View runat="server" ID="View1">
        <asp:Label ID="lblBookName" runat="server" Text="BLibraryBook Name"></asp:Label>
        <asp:TextBox ID="txtBookName" runat="server" style="margin-left: 15px" Width="96px"></asp:TextBox><br /><br />
        <asp:Label ID="lblAuthorName" runat="server" Text="Author"></asp:Label>
        <asp:TextBox ID="txtAuthor" runat="server" style="margin-left: 48px" Width="94px"></asp:TextBox><br /><br />
        <asp:Label ID="lblPrice" runat="server" Text="Price"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server" style="margin-left: 59px" Width="91px"></asp:TextBox><br /><br />
        <asp:Label ID="lblQuantity" runat="server" Text="Quantity"></asp:Label>
        <asp:TextBox ID="txtQuantity" runat="server" style="margin-left: 38px" Width="94px"></asp:TextBox><br /><br />
        <asp:Button ID="btnAddBook" runat="server" Text="Add BLibraryBook" OnClick="btnAddBook_Click" />
        <br />
          </asp:View>
            <asp:View ID="View2" runat="server">
                <asp:TextBox ID="txtIssueBookName" runat="server"></asp:TextBox><br /> <br />
                <asp:TextBox ID="txtIssueAuthor" runat="server"></asp:TextBox><br /> <br />
                <asp:Button ID="btnIssueBook" runat="server" Text="Issue BLibraryBook" OnClick="btnIssueBook_Click" />
                 <asp:Button ID="btnReturnBook" runat="server" Text="Return BLibraryBook" style="margin-left: 53px" Width="95px" OnClick="btnReturnBook_Click" /><br /> <br />
                <asp:GridView ID="gvIssueBook" runat="server"></asp:GridView>
            </asp:View>
        </asp:MultiView>
    </div>
    </form>
</body>
</html>
