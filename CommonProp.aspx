<%@ Page Language="C#" MasterPageFile="~/AdminPage.Master" AutoEventWireup="true" CodeFile="CommonProp.aspx.cs" Inherits="CommonProp" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
    <div class="class1">
        <p>Класс 1</p>

        <p>
            <asp:Calendar ID="Calendar1" runat="server" Height="200px" Width="220px" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" ShowGridLines="True">
                <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                <OtherMonthDayStyle ForeColor="#CC9966" />
                <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                <SelectorStyle BackColor="#FFCC66" />
                <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
            </asp:Calendar>
        </p>

        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        </asp:UpdatePanel>

    </div>
<div class="class2">
        <p><b>Класс 2</b></p>
        <p>
            <asp:Calendar ID="Calendar2" runat="server" Height="500px" Width="500px"></asp:Calendar>
        </p>

    </div><div id="class3">
        <p><b>Класс 3</b></p>
        <p>
            <asp:Calendar ID="Calendar3" runat="server" Height="500px" Width="500px"></asp:Calendar>
        </p>

    </div>
</asp:Content>
