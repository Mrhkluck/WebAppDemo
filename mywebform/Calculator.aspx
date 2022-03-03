<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Calculator.aspx.cs" Inherits="WebAppDemo.mywebform.Calculator" %>
    
    

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <%-- <form id="form1" runat="server">--%>
        <div>
            <h1 align ="center">Working with ASP.Net WebForm</h1>

        </div>
        <table align="center" class="auto-style1">
            <tr>
                <td><strong>First Number</strong></td>
                <td>
                    <asp:TextBox ID="txtNum1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td><strong>Second Number</strong></td>
                <td>
                    <asp:TextBox ID="txtNum2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td><strong>Third Number</strong></td>
                <td>
                    <asp:TextBox ID="txtNum3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style2">
                    <asp:Button ID="BtnAdd" runat="server" Text="Add Value" BackColor="Lime" ForeColor="#FF9900" OnClick="BtnAdd_Click"/>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" ></asp:Label>
                    </td>
            </tr>
        </table>
 <%--   </form>--%>
</asp:Content>

