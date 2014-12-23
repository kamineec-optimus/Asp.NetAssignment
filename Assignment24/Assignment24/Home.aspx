<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Assignment24.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <br /> <br />
        <asp:HyperLink ID="hlinkXML" runat="server" Target="_blank" NavigateUrl="~/Test.Xml">XML File</asp:HyperLink><br /><br />
        <asp:Button ID="btnAddNode" runat="server" Text="Add Node" OnClick="btnAddNode_Click" />
       
    </div>
        
        <p>
            <asp:TextBox ID="txtNode" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="btnFirstChild" runat="server" Text="First Child" OnClick="btnFirstChild_Click" /><br /> <br />

        <asp:Button ID="btnInsertBefore" runat="server" Text="InsertEmptyNode" OnClick="btnInsertBefore_Click" /><br /> <br />
        <asp:Button ID="btnRemoveNode" runat="server" Text="RemoveAssignmentNode" OnClick="btnRemoveNode_Click" /><br /> <br />
        <asp:Button ID="btnChildNode" runat="server" Text="Child Node" OnClick="btnChildNode_Click" /><br /><br />
        <asp:Button ID="btnReplace" runat="server" Text="ReplaceNode" OnClick="btnReplace_Click" />
    </form>
</body>
</html>
