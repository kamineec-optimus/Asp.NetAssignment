<%@ Page Language="C#"  AutoEventWireup="true" CodeBehind="TestIf.aspx.cs" EnableViewState="true" Inherits="Ques1.TestIf"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:RadioButton ID="rbtnC" runat="server" Text="C#" GroupName="a" AutoPostBack="true"  />
        <asp:RadioButton ID="rbtnVB" runat="server" Text="VB" GroupName="a" AutoPostBack="true" />
        <asp:RadioButton ID="rbtnOther" runat="server" Text="Other" GroupName="a" AutoPostBack="true" />   <br />
    <asp:Label ID="lbl" runat="server" Text=" "></asp:Label>

    </div>
    </form>
</body>
</html>
