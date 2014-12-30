<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="Assignment25.Student" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body>
    <form id="form1" runat="server">
    <div>
    <asp:button ID="btnPrintStudent" runat="server" text="Print MCA Student" OnClick="btnPrintStudent_Click" /><br /> <br />
        <asp:Label ID="lblName" runat="server" Text=" "></asp:Label><br /><br />
        <asp:Button runat="server" ID="btnGradeD" Text="Student With Grade D" OnClick="btnGradeD_Click"/><br /> <br />
        <asp:Label ID="lblGrade" runat="server" Text=""></asp:Label>
    </div>
        
    </form>
</body>
</html>
