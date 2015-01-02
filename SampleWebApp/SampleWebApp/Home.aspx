<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="SampleWebApp.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>    
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="lblPercentage" runat="server" Text="Enter your Percentage"></asp:Label>
    <asp:TextBox ID="txtPercentage" runat="server" style="margin-left: 59px" Width="108px"></asp:TextBox><br /><br />
    <asp:Button ID="btnCalculateMarks" runat="server" Text="CalculateMarks" OnClick="btnCalculateMarks_Click" style="margin-left: 194px" Width="114px" /><br /><br />
    <asp:Label ID="lblMarks" runat="server" Text=""></asp:Label>

        
    </div>
    </form>
</body>
</html>
