<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="AdoDotNetObjectCaching.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">        
    <div>
        <asp:Button ID="btnLoadData" runat="server" Text="Load Data" OnClick="btnLoadData_Click" />
        <asp:Button ID="btnClearCache" runat="server" Text="Chear Cache" OnClick="btnClearCache_Click" /><br /><br />
        <asp:Label ID="lblMessage" runat="server" ></asp:Label><br /><br />
        <asp:GridView ID="gvEmployee" runat="server"></asp:GridView>
        
    </div>
    </form>
</body>
</html>
