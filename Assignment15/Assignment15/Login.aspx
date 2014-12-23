<%@  Page    Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Assignment15.Login" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      
    <asp:Literal ID="ltrlMsg" runat="server" Text="Please Login"></asp:Literal><br /> <br />

<asp:Label ID="lblUSerName" runat="server" Text="User Name"></asp:Label>
<asp:TextBox ID="txtUserName" runat="server" style="margin-left: 31px" Width="131px"></asp:TextBox><br /> <br />
<asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
<asp:TextBox ID="txtPassword" runat="server" style="margin-left: 41px" Width="129px"></asp:TextBox><br /> <br />
    
<asp:Button ID="btnLogin" runat="server" Text="Login" style="margin-left: 145px" Width="92px" OnClick="btnLogin_Click" />          
</asp:Content>