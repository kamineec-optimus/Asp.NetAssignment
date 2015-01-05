<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="MVPDesignPattern.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>    
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Button ID="btnIncreaseStock" runat="server" Text="Increase Stock" OnClick="btnIncreaseStock_Click" />
    <asp:Button ID="btnDecreaseStock" runat="server" Text="Decrease Stock" OnClick="btnDecreaseStock_Click" style="margin-left: 53px" Width="115px" /><br /><br />
    <asp:TextBox ID="txtStockValue" runat="server" style="margin-left: 69px" Width="125px"></asp:TextBox>
   
    </div>
    </form>
</body>
</html>
