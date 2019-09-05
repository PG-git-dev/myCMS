<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ImageCrop.aspx.cs" Inherits="ImageCrop" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
    <title></title>
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <meta name="viewport" content="user-scalable=no, width=device-width, initial-scale=1, maximum-scale=1">
  <link type="text/css" media="screen" rel="stylesheet" href="scripts/jquery.cropbox.css">
  <script type="text/javascript" src="scripts/jquery.min.js"></script>
  <script type="text/javascript" src="scripts/hammer.min.js"></script>
  <script type="text/javascript" src="scripts/jquery.mousewheel.js"></script>
  <script type="text/javascript" src="scripts/jquery.cropbox.js"></script>
  <script type="text/javascript" src="scripts/crop.js"></script>
  <style type="text/css">
    body {
      font-family : sans-serif;
      font-size   : 13px;
    }
    .results {
      font-family : monospace;
      font-size   : 20px;
    }
  </style>
</head>
<body style="height: 1097px">
    <form id="form1" runat="server">
        <br>
        <asp:panel id="Panel2" runat="server">
            <br>
            <br>
            <div>
                <img id="cropimage" alt="picture" class="cropimage" cropheight="200" cropwidth="200" src="mysite\images\85d354c0e0ab6d614fe0690448f70a50.jpg">
                <div class="results">
                    <b>X</b>: <span class="cropX"></span><br>
                    <b>Y</b>: <span class="cropY"></span><br>
                    <b>W</b>: <span class="cropW"></span><br>
                    <b>H</b>: <span class="cropH"></span>
                </div>
                <div class="download">
                    <a download="croped_85d354c0e0ab6d614fe0690448f70a50.jpg" href="C:\">Download</a>
                </div>
                </div>
            <br>
        </asp:panel>
        <br>
        <br>
        <br>
                <br>
                <asp:fileupload id="ImageForCropFileUpload" runat="server" allowmultiple="false"></asp:fileupload>
                <asp:button id="Button1" runat="server" onclick="Button1_Click" style="margin-left: 44px" text="Загрузить"></asp:button>
                <br>
                <br>
                <asp:button id="Button2" runat="server" onclick="Button2_Click" text="Применить"></asp:button>
                <br>
        <br>
        <asp:panel id="Panel1" runat="server" onload="Panel1_Load">
            <div>
            </div>
        </asp:panel>
    </form>
</body>
</html>
