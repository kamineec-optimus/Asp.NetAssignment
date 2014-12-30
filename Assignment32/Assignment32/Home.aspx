<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Assignment32.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <asp:GridView ID="gvUserDetail" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Id" DataSourceID="entityUserDataSource" ForeColor="#333333" GridLines="None" OnRowDataBound="gvUserDetail_RowDataBound" >
             <AlternatingRowStyle BackColor="White" />
             <Columns>            
                 <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />                 
                 <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
                 <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                 <asp:BoundField DataField="MobileNo" HeaderText="MobileNo" SortExpression="MobileNo" />
                 <asp:BoundField DataField="UserName" HeaderText="UserName" SortExpression="UserName" />                 
                 <asp:BoundField DataField="RoleId" HeaderText="RoleId" SortExpression="RoleId" />
             </Columns>
             <EditRowStyle BackColor="#2461BF" />
             <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
             <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
             <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
             <RowStyle BackColor="#EFF3FB" />
             <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
             <SortedAscendingCellStyle BackColor="#F5F7FB" />
             <SortedAscendingHeaderStyle BackColor="#6D95E1" />
             <SortedDescendingCellStyle BackColor="#E9EBEF" />
             <SortedDescendingHeaderStyle BackColor="#4870BE" />
         </asp:GridView>       
        <asp:EntityDataSource ID="entityUserDataSource" runat="server" ConnectionString="name=EntityFrameworkEntities" DefaultContainerName="EntityFrameworkEntities" EnableFlattening="False" EntitySetName="UserDetails" EnableDelete="True" EnableInsert="True" EnableUpdate="True"></asp:EntityDataSource>
        <br /><br /> 
         <asp:MultiView ID="mvHomePage" runat="server" ActiveViewIndex=0>
        <asp:View ID="View1" runat="server">
          <asp:DetailsView  runat="server" AutoGenerateRows="False" CellPadding="4" DataKeyNames="Id" DataSourceID="entityUserDataSource" DefaultMode="Insert" ForeColor="#333333" GridLines="None" Height="50px" Width="125px" OnItemInserted="DetailsView1_ItemInserted">
               <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
               <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
               <EditRowStyle BackColor="#999999" />
               <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />
               <Fields>
                   <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" InsertVisible="false" />
                   <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                   <asp:BoundField DataField="MobileNo" HeaderText="MobileNo" SortExpression="MobileNo" />
                   <asp:BoundField DataField="UserName" HeaderText="UserName" SortExpression="UserName" />                     
                   <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" />
                   <asp:BoundField DataField="RoleId" HeaderText="RoleId" SortExpression="RoleId" />
                   <asp:CommandField ShowInsertButton="True" />
               </Fields>
               <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
               <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
               <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
               <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
         </asp:DetailsView>
           <br /><br />          
        </asp:View>
        </asp:MultiView>
        <asp:Button ID="lblFileUpload" runat="server" Text="Upload File" OnClick="lblFileUpload_Click"></asp:Button><asp:FileUpload ID="fupFileUploader" runat="server" />
        </div>
        
    </form>
</body>
</html>
