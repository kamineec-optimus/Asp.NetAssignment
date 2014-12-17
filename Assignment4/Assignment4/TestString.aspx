<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestString.aspx.cs" Inherits="Assignment4.TestString" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
    <div>
        <asp:Literal ID="Literal1" runat="server" Text=" Here are some basic operation on string:"></asp:Literal><br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
         <asp:Label ID="Label2" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label><br />
        <asp:Button ID="btnClone" runat="server" Text="Clone A String" OnClick="btnClone_Click" /><br />
        <asp:Button ID="btnCompareTo" runat="server" Text="CompareTo" OnClick="btnCompareTo_Click" /><br />
        <asp:Button ID="btnContains" runat="server" Text="Contains" OnClick="btnContains_Click" /><br />
        <asp:Button ID="btnIndexOf" runat="server" Text="Find Index of any charecter" OnClick="btnIndexOf_Click" /><br />
        <asp:Button ID="btnToLower" runat="server" Text="ToLower" OnClick="btnToLower_Click" /><br />
        <asp:Button ID="btnToUpper" runat="server" Text="ToUpper" OnClick="btnToUpper_Click" /><br />
        <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" /><br />
        <asp:Button ID="btnLength" runat="server" Text="Length" OnClick="btnLength_Click" /><br />
        <asp:Button ID="btnLastIndexOF" runat="server" Text="LastIndexOF" OnClick="btnLastIndexOF_Click" /><br />
        <asp:Button ID="btnRemove" runat="server" Text="Remove" OnClick="btnRemove_Click" /><br />
        <asp:Button ID="btnReplace" runat="server" Text="Replace" OnClick="btnReplace_Click" /><br />
     </div>
    </form>
</body>
</html>
