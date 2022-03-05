<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebAppDemo.DatabaseWork.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table style="width: 34%; background-color: #66AFE9">
        <tr>
            <td class="modal-sm" style="width: 293px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 293px">Login Here:</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 293px">UserName</td>
            <td>
                <asp:TextBox ID="TxtUserName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 293px">Password</td>
            <td>
                <asp:TextBox ID="TxtPassword" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 293px">&nbsp;</td>
            <td>
                <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Sign In" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="height: 32px; width: 293px"></td>
            <td class="auto-style2" style="height: 32px">
                <asp:Label ID="lblMessage" runat="server"></asp:Label>
            </td>
        </tr>
    </table>

</asp:Content>
