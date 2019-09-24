<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <!--<div class="jumbotron">
        <h1>Конструктор одностраничных сайтов АКБ "Российский Капитал" (ПАО)</h1>
        <p class="lead">Выберете необходимую опцию</p>
            <div class="col-md-12 col-xs-6">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Создать сайт" Width="212px" Height="111px" />
                <asp:Button ID="Button2" runat="server" Text="Выбрать сайт" Width="212px" Height="111px" OnClick="Button2_Click" />
            </div>
<!--        <p><a href="MyPage.aspx" class="btn btn-primary btn-lg">Learn more &raquo;</a></p> 
    </div>-->


    <div class="bs-docs-header" id="content" tabindex="-1"> 
        <h1>Конструктор одностраничных сайтов</h1> 
    </div>

    <div>
        <div class="box_buttons">
            <p>Выберите необходимую опцию</p> 
                <asp:Button class="main_button" ID="Button4" runat="server" Text="Выбрать сайт" OnClientClick="window.open('SiteLoadPage')" />
                <asp:Button class="main_button"  ID="Button3" runat="server" OnClick="Button1_Click" Text="Создать сайт"/>
            </div>
    </div>

<!--    <div class="row">
        <div class="col-md-4">
            <h2>Getting started</h2>
            <p>
                ASP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
            A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
    </div>
-->
</asp:Content>
