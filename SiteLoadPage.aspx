<%@ Page Language="C#" AutoEventWireup="true" Title="AdministrativePage" MasterPageFile="~/AdminPage.Master" CodeFile="SiteLoadPage.aspx.cs" Inherits="SiteLoadPage" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<%--    <form id="form1" runat="server">--%>
        <div class="box_buttons">

            <asp:Label ID="Label1" class="h1" runat="server" Text="Выберите сайт"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" class="little_input" placeholder="Введите название сайта" Width="142px"></asp:TextBox>
            <div><asp:Button ID="Button1" runat="server" class="usual_btn" OnClick="Button1_Click" Text="Открыть" /></div>

        </div>
    <%--</form>--%>
</asp:Content>