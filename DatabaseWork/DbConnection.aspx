<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DbConnection.aspx.cs" Inherits="WebAppDemo.DatabaseWork.DbConnection" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <asp:Button ID="Button1" runat="server" Text="Connect with Database" OnClick="Button1_Click" />
    <br />
    <br />
    
    <asp:Button ID="Button2" runat="server" Text="Disconnect from Database" OnClick="Button2_Click" />
    <br />
    <br />
   
    <asp:Button ID="Button3" runat="server" Text="Check Connection State" OnClick="Button3_Click" />
    
    <br />
    <br />
</asp:Content>
