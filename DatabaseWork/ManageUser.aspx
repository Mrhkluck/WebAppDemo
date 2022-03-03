<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" Async="true"
    CodeBehind="ManageUser.aspx.cs" Inherits="WebAppDemo.DatabaseWork.ManageUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 70%; margin:auto; border: 2px solid #0000FF; background-color: #CCFFCC">
        <tr>
            <td colspan="2">ManageUser:</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 339px">User ID</td>
            <td>
                <asp:TextBox ID="txtUserId" runat="server"></asp:TextBox>
            &nbsp;<asp:Button ID="btnSearch" runat="server" Text="Find User" OnClick="Btn_Click" />
            </td>
        </tr>
        <tr>
            <td style="width: 339px">User Name:</td>
            <td>
                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            &nbsp;</td>
        </tr>
       <%-- <tr>
            <td style="width: 339px">Password:</td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            &nbsp;<asp:Button ID="Button3" runat="server" Text="Button" />
            </td>
        </tr>--%>
        <tr>
            <td style="width: 339px">Full Name:</td>
            <td>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2" style="height: 35px; width: 339px">Mobile:</td>
            <td class="auto-style2" style="height: 35px">
                <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
            &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2" style="height: 35px; width: 339px">
                <asp:Button ID="btnUpdate" runat="server" Text="Update User" OnClick="btnUpdate_Click" />
            </td>
            <td class="auto-style2" style="height: 35px">
                <asp:Button ID="btnDelete" runat="server" Text="Delete User" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnVierAll" runat="server" Text="View All Users" OnClick="btnVierAll_Click" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="GridView1" runat="server">
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
