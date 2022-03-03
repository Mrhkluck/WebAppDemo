<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddUser.aspx.cs" Inherits="WebAppDemo.DatabaseWork.AddUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <table style="width: 70%; margin:auto; border: 2px solid #0000FF; background-color: #CCFFCC">
        <tr>
            <td colspan="2">Add New User Page</td>
        </tr>
        <tr>
            <td style="width: 339px">User Name:</td>
            <td>
                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 339px">Password:</td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 339px">Full Name:</td>
            <td>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="height: 35px; width: 339px">Mobile:</td>
            <td class="auto-style2" style="height: 35px">
                <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="height: 35px; width: 339px">&nbsp;</td>
            <td class="auto-style2" style="height: 35px">
                <asp:Button ID="btnSave" runat="server" Text="Add User" OnClick="btnSave_Click" />
            </td>
        </tr>
    </table>


</asp:Content>
