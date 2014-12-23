<%@ Page MasterPageFile="~/masterPage.Master" Language="C#" AutoEventWireup="true" CodeBehind="techNews.aspx.cs" Inherits="Assignment15.techNews" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
        <asp:Literal ID="ltrltechNews" runat="server" Text="Tech News Page"></asp:Literal>  
      <asp:HyperLink runat="server" Text="Extra Curricular Activites" NavigateUrl="~/extraCurr.aspx"></asp:HyperLink>
    </asp:Content>