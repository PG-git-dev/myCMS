<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MyPage.aspx.cs" EnableViewStateMac="True" Inherits="MyPage"%> 

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>AdministrativePage</title> 
    <!--   <asp:Literal runat="server" Text="<!--%#GetTitle() %>"></asp:Literal> -->
</head>
<body style="height: 793px">
    <form id="form1" runat="server" enableviewstate="True" autopostback="true">
    <div style="width: 354px; height: 793px" >
        <!--<div style="background-color:darkgray" >-->
        My page<br />
        <br />
        
        <asp:Button ID="Button1" runat="server" Text="Просмотр" OnClick="<%#GetSitePath() %>" Enabled="True" /> <!--OnClick="Button1_Click"--> <!--OnClientClick="window.open('header1.html')" --> <!--OnClick="<!--%#GetSitePath() %>"-->
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="margin-left: 62px" Text="Добавить" />
        <br />
        <br />
        <!--</div>-->
        <hr />
        <asp:Label ID="Label1" runat="server" Text="Заголовок страницы:"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Width="112px" AutoPostBack="false" Text="It is a title's text" OnPreRender="TextPreRender" MaxLength="25"></asp:TextBox>
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" style="margin-left: 33px" Text="Сохранить" Width="87px" />
        <hr />
        <br />
        <br />
        <img alt="" src="https://ipoteka.roscap.ru/wp-content/uploads/2017/03/cropped-favicon-32x32.png" style="height: 69px; width: 86px" />
        <hr />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Фавиконка:"></asp:Label>
        <br />
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        <br />
        <asp:Button ID="ButtonFixFileUpload" runat="server" OnClick="ButtonFixFileUpload_Click" style="margin-left: 4px" Text="Выбрать" Width="81px"  />

        <br />
        <hr />
        <asp:Label ID="Label2" runat="server" Text="Заголовок банера:"></asp:Label>
    
        <br />
        <textarea id="BannerHeaderTextArea" runat="server" cols="20" maxlength="50" name="S1" onprerender="TextPreRender"></textarea>
        <br />
    
        <asp:Label ID="Label5" runat="server" Text="Формат представления информации на банере:"></asp:Label>
    
        <br />
        <br />
        <asp:RadioButton ID="RadioButtonText" runat="server" GroupName="BannerTextStyle" AutoPostBack="True" OnCheckedChanged="RadioButton_CheckedChanged" Text="Текст" />
        <br />
        <asp:RadioButton ID="RadioButtonBullet" runat="server" GroupName="BannerTextStyle" AutoPostBack="True" OnCheckedChanged="RadioButton_CheckedChanged" Text="Буллиты" Checked="True" />
        <br />
        <br />
    
        <asp:Label ID="Label4" runat="server" Text="Текст банера:"></asp:Label>
    
        <br />
        <textarea id="BannerTextArea" runat="server" cols="30" maxlength="90" name="S2" disabled="disabled"></textarea>
        <br />
    
        <asp:Label ID="Label6" runat="server" Text="Текст буллита 1:"></asp:Label>
    
        &nbsp;<textarea id="Bullet1TextArea" runat="server" cols="25" maxlength="50" name="S3" onprerender="TextPreRender" required></textarea><br />
    
        <asp:Label ID="Label7" runat="server" Text="Текст буллита 2:"></asp:Label>
    
        &nbsp;<textarea id="Bullet2TextArea" runat="server" cols="25" maxlength="50" name="S4" onprerender="TextPreRender" required></textarea><br />
    
        <asp:Label ID="Label8" runat="server" Text="Текст буллита 3:"></asp:Label>
    
        &nbsp;<textarea id="Bullet3TextArea" runat="server" cols="25" maxlength="50" name="S5" ></textarea><br />
    
        <asp:Label ID="Label9" runat="server" Text="Текст буллита 4:"></asp:Label>
    
        &nbsp;<textarea id="Bullet4TextArea" runat="server" cols="25" maxlength="50" name="S5" ></textarea><br />

        <asp:CheckBox ID="BannerCheckBox" runat="server" OnCheckedChanged="BlockVisibilityCheckBox_CheckedChanged" ValidationGroup="BlockVisibility" Checked="true" />

    </div>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="False">
            <asp:ListItem>Header</asp:ListItem>
            <asp:ListItem>MainMenu</asp:ListItem>
            <asp:ListItem>Menu1</asp:ListItem>
            <asp:ListItem>Footer</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <br />
        <hr />
        <asp:Panel ID="CardImageBlockPanel" runat="server">
            Блок с карточками.<br />
            <asp:Label ID="Label10" runat="server" Text="Заголовок блока:"></asp:Label>
            <br />
            <textarea id="CardBlockHeaderTextArea" runat="server" maxlength="50" name="S6" onprerender="TextPreRender"></textarea>
            <br />
            <br />
            <asp:RadioButton ID="RadioButtonWithHeader" runat="server" AutoPostBack="True" Checked="True" GroupName="CardImageHeader" OnCheckedChanged="RadioButtonCardImageHeader_CheckedChanged" Text="Текст в карточках с заголовком" />
            <br />
            <asp:RadioButton ID="RadioButtonWithoutHeader" runat="server" AutoPostBack="True" GroupName="CardImageHeader" OnCheckedChanged="RadioButtonCardImageHeader_CheckedChanged" Text="Текст в карточках без заголовка" />
            <br />
            <br />
            <asp:Button ID="CardImageBlockHeaderButton" runat="server" OnClick="CardImageBlockHeaderButton_Click" Text="Сохранить" />
            <br />
            <asp:CheckBox ID="CardImageBlockCheckBox" runat="server" OnCheckedChanged="BlockVisibilityCheckBox_CheckedChanged"  ValidationGroup="BlockVisibility"  Checked="true"/>
            <br />
            <br />
        </asp:Panel>
        <br />
        <asp:Panel ID="CardImagePanel1" runat="server">
        <br />
                Карточка 1<br />
            <br />
                <asp:Button ID="ButtonCard1" runat="server" Text="Картинка" OnClick="ButtonCard1_Click" /><!--здесь по идее -->
            <br />
        <br />
        <asp:FileUpload ID="FileUploadImageCardBlock1" runat="server" />
        <br />
        <br />
        <br />
        Текст заголовка:<br />
        <textarea id="TextAreaImageBlockHeader1" runat="server" name="S10" rows="2" maxlength="25" onprerender="TextPreRender"></textarea><br />
            <br />
                <asp:Label ID="Label11" runat="server" Text="Текст карточки:"></asp:Label>
            <br />
                <textarea id="CardBlockTextArea1" runat="server" cols="30" maxlength="90" name="S7" onprerender="TextPreRender" rows="1"></textarea><br />
            <br />
                <asp:Button ID="CardImageSaveButton1" runat="server" OnClick="CardImageSaveButton1_Click" Text="Сохранить" />
                <br />
        <br />
        </asp:Panel>

        <asp:Panel ID="CardImagePanel2" runat="server">
            Карточка 2<br />
            <br />
            <asp:Button ID="ButtonCard2" runat="server" Text="Картинка" OnClick="ButtonCard2_Click" />
            <br />
            <br />
            <asp:FileUpload ID="FileUploadImageCardBlock2" runat="server" />
            <br />
            <br />
            Текст заголовка:<br />
            <textarea id="TextAreaImageBlockHeader2" runat="server" cols="20" maxlength="25" name="S11" onprerender="TextPreRender" rows="2"></textarea><br />
            <br />
            <asp:Label ID="Label12" runat="server" Text="Текст карточки:"></asp:Label>
            <br />
            <textarea id="CardBlockTextArea2" runat="server" onprerender="TextPreRender" cols="30" maxlength="90" name="S8" rows="1"></textarea><br />
            <br />
            <asp:Button ID="CardImageSaveButton2" runat="server" OnClick="CardImageSaveButton2_Click" Text="Сохранить" />
            <br />
        </asp:Panel>
        <br />
        <asp:Panel ID="CardImagePanel3" runat="server">
            Карточка 3<br />
            <br />
            <asp:Button ID="ButtonCard3" runat="server" Text="Картинка" OnClick="ButtonCard3_Click" />
            <br />
            <br />
            <asp:FileUpload ID="FileUploadImageCardBlock3" runat="server" />
            <br />
            <br />
            Текст заголовка:<br />
            <textarea id="TextAreaImageBlockHeader3" runat="server" cols="20" maxlength="25" name="S12" onprerender="TextPreRender" rows="2"></textarea><br />
            <br />
            <asp:Label ID="Label13" runat="server" Text="Текст карточки:"></asp:Label>
            <br />
            <textarea id="CardBlockTextArea3" onprerender="TextPreRender" runat="server" cols="30" maxlength="90" name="S9" rows="1"></textarea><br />
            <br />
            <asp:Button ID="CardImageSaveButton3" runat="server" OnClick="CardImageSaveButton3_Click" Text="Сохранить" />
            <br />
            <br />
            <hr />
        </asp:Panel>
        <asp:Panel ID="CardDigitPanel" runat="server">
            Блок с цифровыми карточками:<br />
            <asp:CheckBox ID="CardDigitCheckBox" runat="server" OnCheckedChanged="BlockVisibilityCheckBox_CheckedChanged" ValidationGroup="BlockVisibility"  Checked="true"/>
            <br />
            <asp:Label ID="Label17" runat="server" Text="Заголовок блока:"></asp:Label>
            <br />
            <textarea id="CardDigitHeaderTextarea" runat="server" maxlength="50" name="S6" onprerender="TextPreRender"></textarea>
            <br />
            <asp:Button ID="CardDigitBlockHeaderSaveButton" runat="server" OnClick="CardDigitBlockHeaderSaveButton_Click" Text="Сохранить" />
            <br />
            <br />
        </asp:Panel>
        <br />
        <br />
        <asp:Panel ID="CardDigitPanel1" runat="server">
            <br />
            Карточка 1<br />
            <br />
            <asp:Label ID="Label14" runat="server" Text="Текст карточки 1:"></asp:Label>
            <br />
            <textarea id="CardDigitTextarea1" runat="server" cols="30" maxlength="90" name="S7" onprerender="TextPreRender" rows="1"></textarea><br />
            <br />
            <asp:Button ID="CardDigitButton1" runat="server" OnClick="CardDigitSaveButton1_Click" Text="Сохранить" />
            <br />
            <br />
        </asp:Panel>
        <asp:Panel ID="CardDigitPanel2" runat="server">
            Карточка 2<br />
            <br />
            <asp:Label ID="Label15" runat="server" Text="Текст карточки 2:"></asp:Label>
            <br />
            <textarea id="CardDigitTextarea2" runat="server" onprerender="TextPreRender" cols="30" maxlength="90" name="S8" rows="1"></textarea><br />
            <br />
            <asp:Button ID="CardDigitButton2" runat="server" OnClick="CardDigitSaveButton2_Click" Text="Сохранить" />
            <br />
        </asp:Panel>
        <br />
        <asp:Panel ID="CardDigitPanel3" runat="server">
            Карточка 3<br />
            <br />
            <asp:Label ID="Label16" runat="server" Text="Текст карточки 3:"></asp:Label>
            <br />
            <textarea id="CardDigitTextarea3" onprerender="TextPreRender" runat="server" cols="30" maxlength="90" name="S9" rows="1"></textarea><br />
            <br />
            <asp:Button ID="CardDigitButton3" runat="server" OnClick="CardDigitSaveButton3_Click" Text="Сохранить" />
            <br />
            <hr />
        </asp:Panel>
        <asp:Panel ID="VarNumberCardBlockPanel" runat="server">
            Блок с карточками, в котором меняются цифры:<br />
            <asp:CheckBox ID="VarNumberCheckBox" runat="server" OnCheckedChanged="BlockVisibilityCheckBox_CheckedChanged" ValidationGroup="BlockVisibility"  Checked="true"/>
            <br />
            <asp:Label ID="Label18" runat="server" Text="Заголовок блока:"></asp:Label>
            <br />
            <textarea id="VarNumberCardBlockTextarea" runat="server" maxlength="50" name="S6" onprerender="TextPreRender"></textarea>
            <br />
            <asp:Button ID="VarNumberCardBlockHeaderSaveButton" runat="server" OnClick="VarNumberCardBlockHeaderSaveButton_Click" Text="Сохранить" />
            <br />
            <br />
        </asp:Panel>
        <br />
        <br />
        <asp:Panel ID="VarNumberCardPanel1" runat="server">
            <br />
            Карточка 1<br />
            <br />
            <asp:Label ID="Label22" runat="server" Text="Номер карточки 1:"></asp:Label>
            <br />
            <textarea id="VarNumberCardNumberTextarea1" runat="server" cols="30" maxlength="90" name="S7" onprerender="TextPreRender" rows="1"></textarea><br />
            <br />
            <asp:Label ID="Label19" runat="server" Text="Текст карточки 1:"></asp:Label>
            <br />
            <textarea id="VarNumberCardTextarea1" runat="server" cols="30" maxlength="90" name="S7" onprerender="TextPreRender" rows="1"></textarea><br />
            <br />
            <asp:Button ID="VarNumberCardSaveButton1" runat="server" OnClick="VarNumberCardSaveButton1_Click" Text="Сохранить" />
            <br />
            <br />
        </asp:Panel>
        <asp:Panel ID="VarNumberCardPanel2" runat="server">
            Карточка 2<br />
            <br />
            <asp:Label ID="Label23" runat="server" Text="Номер карточки 2:"></asp:Label>
            <br />
            <textarea id="VarNumberCardNumberTextarea2" runat="server" cols="30" maxlength="90" name="S7" onprerender="TextPreRender" rows="1"></textarea><br />
            <br />
            <asp:Label ID="Label20" runat="server" Text="Текст карточки 2:"></asp:Label>
            <br />
            <textarea id="VarNumberCardTextarea2" runat="server" onprerender="TextPreRender" cols="30" maxlength="90" name="S8" rows="1"></textarea><br />
            <br />
            <asp:Button ID="VarNumberCardSaveButton2" runat="server" OnClick="VarNumberCardSaveButton2_Click" Text="Сохранить" />
            <br />
        </asp:Panel>
        <br />
        <asp:Panel ID="VarNumberCardPanel3" runat="server">
            Карточка 3<br />
            <br />
            <asp:Label ID="Label24" runat="server" Text="Номер карточки 3:"></asp:Label>
            <br />
            <textarea id="VarNumberCardNumberTextarea3" runat="server" cols="30" maxlength="90" name="S7" onprerender="TextPreRender" rows="1"></textarea><br />
            <br />
            <asp:Label ID="Label21" runat="server" Text="Текст карточки 3:"></asp:Label>
            <br />
            <textarea id="VarNumberCardTextarea3" onprerender="TextPreRender" runat="server" cols="30" maxlength="90" name="S9" rows="1"></textarea><br />
            <br />
            <asp:Button ID="VarNumberCardSaveButton3" runat="server" OnClick="VarNumberCardSaveButton3_Click" Text="Сохранить" />
            <br />
            <hr/>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />

        </asp:Panel>
        <asp:Panel ID="Table" runat="server">
            <asp:Label ID="Label25" runat="server" Text="Таблица"></asp:Label>
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <br />
            
            <br />
        </asp:Panel>
&nbsp;<br />
        <br />
        <br />
        <hr />
        <br />
        <asp:MultiView ID="MultiView1" runat="server">
            <asp:View ID="View1" runat="server">



            </asp:View>
        </asp:MultiView>
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Panel Height="200px" Width="50%" ID="Panel1" runat="server" HorizontalAlign="Justify">
            <!DOCTYPE HTML>
            <link href="Style.css" rel="stylesheet" type="text/css" />
            <!--Это по-хорошему нужно задаваить программно (именно текст между тегами). Это то, что отображается в заголовке вкладки.--><title2>page</title2>
            <!--Сюда нужно закидывать программно иконочку (при надобности программно обрезать ее до нужного размера). Это фавиконка во вкладке.-->
            <link href="https://ipoteka.roscap.ru/wp-content/uploads/2017/03/cropped-favicon-32x32.png" rel="icon" sizes="32x32" />
            <!--Первый варик хедера-->
            <!--Вот сюда нужно подпихивать другие варики блоков. Пока надо подумать, как это будет все смотреться и как к этому подрубать стили...-->
            <!-- 	<div class="wrapper">
		<header class="header">Header</header>
		<article class="main">
			<p>Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Vestibulum tortor quam, feugiat vitae, ultricies eget, tempor sit amet, ante. Donec eu libero sit amet quam egestas semper. Aenean ultricies mi vitae est. Mauris placerat eleifend leo.</p>  
		</article>
		<aside class="aside aside-1">Aside 1</aside>
		<aside class="aside aside-2">Aside 2</aside>
		<footer class="footer">Footer</footer> -->
            <style>
                header {
                    background: #262626;  
                }
                main {
                    text-align: left;
                    background: #d21f1f;
                }
                footer {
                    background: #f0f0f0;
                }
            </style>
            <header class="header2">
                Header</header>
            <article class="main2">
                <p>
                    Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Vestibulum tortor quam, feugiat vitae, ultricies eget, tempor sit amet, ante. Donec eu libero sit amet quam egestas semper. Aenean ultricies mi vitae est. Mauris placerat eleifend leo.</p>
            </article>
            <footer class="footer2">
                Footer</footer>
            <br />
            <br />
        </asp:Panel>
    </form>

</body>
</html>
