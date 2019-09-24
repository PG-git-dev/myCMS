<%@ Page Title="AdministrativePage" MasterPageFile="~/AdminPage.Master" Language="C#" AutoEventWireup="true" CodeFile="MyPage.aspx.cs" EnableViewStateMac="True" Inherits="MyPage"%> 


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<%--    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
        <ContentTemplate>--%>
        <!--<div style="background-color:darkgray" >-->
        <!--My page<br />
        <br />-->
        
         <!--OnClick="Button1_Click"--> <!--OnClientClick="window.open('header1.html')" --> <!--OnClick="<!--%#GetSitePath() %>"-->
        <%--<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="margin-left: 62px" Text="Добавить" />--%>
    <div class="container cont_margin">
        <div class="admin_block">
            <h3>
                <asp:Label ID="Label1" runat="server" Text="Заголовок страницы"></asp:Label>
            </h3>
            <div class="table_block">
                <div>
                    <asp:TextBox class="little_input" ID="TextBox1" runat="server" AutoPostBack="false" placeholder="Введите текст" Text="It is a title's text" OnPreRender="TextPreRender" MaxLength="25"></asp:TextBox>
                </div>
                <div>
                    <asp:Button class="admin_button rigrt_btn" ID="Button3" runat="server" OnClick="Button3_Click" Text="V"/>
                </div>
            </div>
        </div>
    </div>
    <div class="container cont_margin">
        <div class="admin_block">
        <!--<img alt="" src="https://ipoteka.roscap.ru/wp-content/uploads/2017/03/cropped-favicon-32x32.png" style="height: 69px; width: 86px" /-->
            <h3>
                <asp:Label ID="Label3" runat="server" Text="Выберите изображение для фавиконки:"></asp:Label>
            </h3>
            <asp:FileUpload ID="FileUpload1" runat="server" class="favicon" type="file" />
            <asp:Button ID="ButtonFixFileUpload" runat="server" OnClick="ButtonFixFileUpload_Click" Text="Выбрать" class="usual_btn" />
        </div>
    </div>
    <div class="container cont_margin">
        <div class="admin_block">
            <!--<input type="checkbox" id="MainContent_BannerCheckBox" style="display: none;">-->
<%--            <asp:CheckBox id="BannerCheckBox"  runat="server" style="display: none;" OnCheckedChanged="BlockVisibilityCheckBox_CheckedChanged" ValidationGroup="BlockVisibility" Checked="true" />--%>
            <asp:CheckBox id="BannerCheckBox"  runat="server" />
            <label for="MainContent_BannerCheckBox" class="check">
              <svg width="18px" height="18px" viewBox="0 0 18 18">
                <path d="M1,9 L1,3.5 C1,2 2,1 3.5,1 L14.5,1 C16,1 17,2 17,3.5 L17,14.5 C17,16 16,17 14.5,17 L3.5,17 C2,17 1,16 1,14.5 L1,9 Z"></path>
                <polyline points="1 9 7 14 15 4"></polyline>
              </svg>
            </label>
            <h3>
                <asp:Label ID="Label2" runat="server" Text="Заголовок баннера:"></asp:Label>
            </h3>
            <textarea id="BannerHeaderTextArea" runat="server" cols="20" maxlength="50" name="S1" onprerender="TextPreRender" class="big_input"></textarea>
            <h4>
                <asp:Label ID="Label5" runat="server" Text="Формат представления информации на банере:"></asp:Label>
            </h4>
            <div class="table_block">
                <div>
                    <asp:RadioButton ID="RadioButtonText" runat="server" />
                </div>
                <div>
                    <label class="label_for_radio" for="RadioButtonText">Текст</label>
                </div>
            </div>
            <div class="table_block">
                <div>
                    <asp:RadioButton ID="RadioButtonBullet" runat="server" />
                </div>
                <div>
                    <label for="RadioButtonBullet">Буллиты</label>
                </div>
            </div>
            <h4>
                <asp:Label ID="Label4" runat="server" Text="Текст баннера"></asp:Label>
            </h4>
            <textarea id="BannerTextArea" runat="server" cols="30" name="S2" disabled="disabled" class="big_input"></textarea>
            <h4>
                Текст буллитов
            </h4>
            <div class="bullits">
                <!--<asp:Label ID="Label6" runat="server" Text="Текст буллита 1:"></asp:Label>-->
                <textarea id="Bullet1TextArea" class="bullit_input" runat="server" cols="25" maxlength="50" name="S3" onprerender="TextPreRender" placeholder="пункт 1" required></textarea>
                <!--<asp:Label ID="Label7" runat="server" Text="Текст буллита 2:"></asp:Label>-->
                <textarea id="Bullet2TextArea" class="bullit_input" runat="server" cols="25" maxlength="50" name="S4" onprerender="TextPreRender" placeholder="пункт 2" required></textarea><br />
                <!--<asp:Label ID="Label8" runat="server" Text="Текст буллита 3:"></asp:Label>-->
                <textarea id="Bullet3TextArea" class="bullit_input" runat="server" cols="25" maxlength="50" name="S5" placeholder="пункт 3"  ></textarea><br />
                <!--<asp:Label ID="Label9" runat="server" Text="Текст буллита 4:"></asp:Label>-->
                <textarea id="Bullet4TextArea" class="bullit_input" runat="server" cols="25" maxlength="50" name="S5" placeholder="пункт 4" ></textarea><br />
            </div>
         </div>
    </div>
    <div class="container cont_margin">
        <div class="admin_block">
            <h3>
       </ContentTemplate>
    </asp:UpdatePanel>
                <asp:Panel ID="CardImageBlockPanel" runat="server">Блок с карточками.
            </h3>
            <h4>
                <asp:Label ID="Label10" runat="server" Text="Заголовок блока:"></asp:Label>
            </h4>
            <textarea id="CardBlockHeaderTextArea" runat="server" maxlength="50" name="S6" onprerender="TextPreRender" class="big_input"></textarea>
            <div class="table_block">
                <div>
                    <asp:RadioButton ID="RadioButtonWithHeader" runat="server" AutoPostBack="True" Checked="True" GroupName="CardImageHeader" OnCheckedChanged="RadioButtonCardImageHeader_CheckedChanged" />
                </div>
                <div>
                    <label class="label_for_radio" for="RadioButtonText">Текст в карточках с заголовком</label>
                </div>
            </div>
            <div class="table_block">
                <div>
                    <asp:RadioButton ID="RadioButtonWithoutHeader" runat="server" AutoPostBack="True" GroupName="CardImageHeader" OnCheckedChanged="RadioButtonCardImageHeader_CheckedChanged" />
                </div>
                <div>
                    <label class="label_for_radio" for="RadioButtonText">Текст в карточках без заголовка</label>
                </div>
            </div>
            <asp:Button ID="CardImageBlockHeaderButton" runat="server" OnClick="CardImageBlockHeaderButton_Click" class="usual_btn" Text="Сохранить" />
                <asp:CheckBox ID="CardImageBlockCheckBox" runat="server" OnCheckedChanged="BlockVisibilityCheckBox_CheckedChanged"  ValidationGroup="BlockVisibility"  Checked="true"/>
            </asp:Panel>
            <asp:Panel ID="CardImagePanel1" runat="server">
            <h4>
                Карточка 1
            </h4>
            <h4>
                <asp:Label ID="CardImageLabel6" runat="server" Text="Выберите файл для изображения на карточке:"></asp:Label>
            </h4>
                <asp:Button ID="ButtonCard1" runat="server" Text="Картинка" OnClick="ButtonCard1_Click" /><p>Это че за кнопка?</p>


            <asp:FileUpload ID="FileUploadImageCardBlock1" runat="server" />

            <h4>
                Текст заголовка: почему это текстом, а следующее версткой???
            </h4>
            <div>
                <textarea id="TextAreaImageBlockHeader1" class="bullit_input" runat="server" name="S10" rows="2" maxlength="25" onprerender="TextPreRender"></textarea>
            </div>
            <h4>
                <asp:Label ID="Label11" runat="server" Text="Текст карточки:"></asp:Label>
            </h4>
            <div>
                <textarea id="CardBlockTextArea1" class="big_input" runat="server" cols="30" maxlength="90" name="S7" onprerender="TextPreRender" rows="1"></textarea>
            </div>
                    <asp:Button ID="CardImageSaveButton1" runat="server" OnClick="CardImageSaveButton1_Click" class="usual_btn" Text="Сохранить" />

            </asp:Panel>

            <asp:Panel ID="CardImagePanel2" runat="server">
                <h4>
                    Карточка 2
                </h4>
                <asp:Button ID="ButtonCard2" runat="server" Text="Картинка" OnClick="ButtonCard2_Click" />
                <asp:FileUpload ID="FileUploadImageCardBlock2" runat="server" />
                <h4>
                    Текст заголовка:
                </h4>
                <div>
                    <textarea id="TextAreaImageBlockHeader2" class="bullit_input" runat="server" cols="20" maxlength="25" name="S11" onprerender="TextPreRender" rows="2"></textarea>
                </div>
                <h4>
                    <asp:Label ID="Label12" runat="server" Text="Текст карточки:"></asp:Label>
                </h4>
                <div>
                    <textarea id="CardBlockTextArea2" runat="server" class="big_input" onprerender="TextPreRender" cols="30" maxlength="90" name="S8" rows="1"></textarea>
                </div>
                <asp:Button ID="CardImageSaveButton2" runat="server" OnClick="CardImageSaveButton2_Click" class="usual_btn" Text="Сохранить" />
                <br />
            </asp:Panel>
            <asp:Panel ID="CardImagePanel3" runat="server">
                <h4>
                Карточка 3
                </h4>
                <asp:Button ID="ButtonCard3" runat="server" Text="Картинка" OnClick="ButtonCard3_Click" />
                <asp:FileUpload ID="FileUploadImageCardBlock3" runat="server" />
                <h4>
                    Текст заголовка:
                </h4>
                <textarea id="TextAreaImageBlockHeader3" class="bullit_input" runat="server" cols="20" maxlength="25" name="S12" onprerender="TextPreRender" rows="2"></textarea>
                <h4>
                    <asp:Label ID="Label13" runat="server" Text="Текст карточки:"></asp:Label>
                </h4>
                <textarea id="CardBlockTextArea3" onprerender="TextPreRender" class="big_input" runat="server" cols="30" maxlength="90" name="S9" rows="1"></textarea>
                <asp:Button ID="CardImageSaveButton3" runat="server" OnClick="CardImageSaveButton3_Click" class="usual_btn" Text="Сохранить" />

            </asp:Panel>
          </div>
    </div>
    <div class="container cont_margin">
        <div class="admin_block">
                <asp:Panel ID="CardDigitPanel" runat="server">
            <h3>
                    Блок с цифровыми карточками:
            </h3>
                <asp:CheckBox ID="CardDigitCheckBox" runat="server" OnCheckedChanged="BlockVisibilityCheckBox_CheckedChanged" ValidationGroup="BlockVisibility"  Checked="true"/>
            <h4>
                <asp:Label ID="Label17" runat="server" Text="Заголовок блока:"></asp:Label>
            </h4>
            <div>
                <textarea id="CardDigitHeaderTextarea" runat="server" maxlength="50" name="S6" onprerender="TextPreRender"  class="big_input"></textarea>
            </div>
                <asp:Button ID="CardDigitBlockHeaderSaveButton" class="usual_btn" runat="server" OnClick="CardDigitBlockHeaderSaveButton_Click" Text="Сохранить" />
            </asp:Panel>
                <asp:Panel ID="CardDigitPanel1" runat="server">
                <h3>
                    Карточка 1
                </h3>
                <h4>
                    <asp:Label ID="Label14" runat="server" Text="Текст карточки 1:"></asp:Label>
                </h4>
                <div>
                    <textarea id="CardDigitTextarea1" class="big_input" runat="server" cols="30" maxlength="90" name="S7" onprerender="TextPreRender" rows="1"></textarea>
                </div>
                <asp:Button ID="CardDigitButton1" class="usual_btn" runat="server" OnClick="CardDigitSaveButton1_Click" Text="Сохранить" />
            </asp:Panel>
            <asp:Panel ID="CardDigitPanel2" runat="server">
                <h3>
                    Карточка 2
                </h3>
                <h4>
                    <asp:Label ID="Label15" runat="server" Text="Текст карточки 2:"></asp:Label>
                </h4>
                <div> 
                    <textarea id="CardDigitTextarea2" class="big_input" runat="server" onprerender="TextPreRender" cols="30" maxlength="90" name="S8" rows="1"></textarea>
                </div>
                <asp:Button ID="CardDigitButton2" class="usual_btn" runat="server" OnClick="CardDigitSaveButton2_Click" Text="Сохранить" />
            </asp:Panel>
            <asp:Panel ID="CardDigitPanel3" runat="server">
                <h3>Карточка 3</h3>
                <h4>
                    <asp:Label ID="Label16" runat="server" Text="Текст карточки 3:"></asp:Label>
                </h4>
                <div>
                    <textarea id="CardDigitTextarea3" class="big_input" onprerender="TextPreRender" runat="server" cols="30" maxlength="90" name="S9" rows="1"></textarea>
                </div>
                <asp:Button ID="CardDigitButton3" CssClass="usual_btn" runat="server" OnClick="CardDigitSaveButton3_Click" Text="Сохранить" />
            </asp:Panel>
        </div>
    </div>
    <div class="container cont_margin">
        <div class="admin_block">
            <asp:Panel ID="VarNumberCardBlockPanel" runat="server">
                <h3>
                    Блок с карточками, в котором меняются цифры:
                </h3>
                <asp:CheckBox ID="VarNumberCheckBox" runat="server" OnCheckedChanged="BlockVisibilityCheckBox_CheckedChanged" ValidationGroup="BlockVisibility"  Checked="true"/>
                <h3>
                    <asp:Label ID="Label18" runat="server" Text="Заголовок блока:"></asp:Label>
                </h3>
                <div>
                    <textarea id="VarNumberCardBlockTextarea" class="big_input" runat="server" maxlength="50" name="S6" onprerender="TextPreRender"></textarea>
                </div>
                <asp:Button ID="VarNumberCardBlockHeaderSaveButton" CssClass="usual_btn" runat="server" OnClick="VarNumberCardBlockHeaderSaveButton_Click" Text="Сохранить" />
            </asp:Panel>
            <asp:Panel ID="VarNumberCardPanel1" runat="server">
                <h3>
                Карточка 1<br />
                </h3>
                <h4>
                <asp:Label ID="Label22" runat="server" Text="Номер карточки 1:"></asp:Label>
                </h4>
                <div>
                <textarea id="VarNumberCardNumberTextarea1" class="little_input" runat="server" cols="30" maxlength="90" name="S7" onprerender="TextPreRender" rows="1"></textarea>
                </div>
                <h4>
                <asp:Label ID="Label19" runat="server" Text="Текст карточки 1:"></asp:Label>
                </h4>
                <div>
                <textarea id="VarNumberCardTextarea1" class="big_input" runat="server" cols="30" maxlength="90" name="S7" onprerender="TextPreRender" rows="1"></textarea>
                </div>
                <asp:Button ID="VarNumberCardSaveButton1" CssClass="usual_btn" runat="server" OnClick="VarNumberCardSaveButton1_Click" Text="Сохранить" />
            </asp:Panel>
            <asp:Panel ID="VarNumberCardPanel2" runat="server">
                <h3>
                Карточка 2
                </h3>
                <h4>
                <asp:Label ID="Label23" runat="server" Text="Номер карточки 2:"></asp:Label>
                </h4>
                <div>
                <textarea id="VarNumberCardNumberTextarea2" class="little_input" runat="server" cols="30" maxlength="90" name="S7" onprerender="TextPreRender" rows="1"></textarea>
                </div>
                <h4>
                <asp:Label ID="Label20" runat="server" Text="Текст карточки 2:"></asp:Label>
                </h4>
                <div>
                <textarea id="VarNumberCardTextarea2" runat="server" class="big_input" onprerender="TextPreRender" cols="30" maxlength="90" name="S8" rows="1"></textarea>
                </div>
                <asp:Button ID="VarNumberCardSaveButton2" CssClass="usual_btn" runat="server" OnClick="VarNumberCardSaveButton2_Click" Text="Сохранить" />
            </asp:Panel>
            <asp:Panel ID="VarNumberCardPanel3" runat="server">
                <h3>Карточка 3</h3>
                <h4>
                <asp:Label ID="Label24" runat="server" Text="Номер карточки 3:"></asp:Label>
                </h4>
                <div>
                <textarea id="VarNumberCardNumberTextarea3" class="little_input" runat="server" cols="30" maxlength="90" name="S7" onprerender="TextPreRender" rows="1"></textarea>
                </div>
                <h4>
                <asp:Label ID="Label21" runat="server" Text="Текст карточки 3:"></asp:Label>
                </h4>
                <div>
                <textarea id="VarNumberCardTextarea3" class="big_input" onprerender="TextPreRender" runat="server" cols="30" maxlength="90" name="S9" rows="1"></textarea>
                </div>
                <asp:Button ID="VarNumberCardSaveButton3" CssClass="usual_btn" runat="server" OnClick="VarNumberCardSaveButton3_Click" Text="Сохранить" />
            </asp:Panel>
            <asp:Panel ID="Table" runat="server">
                <asp:Label ID="Label25" runat="server" Text="Таблица"></asp:Label>
                <asp:GridView ID="GridView1" runat="server">
                </asp:GridView>
            </asp:Panel>
                </h4>
            </div>
           <hr />
            <footer>
                
                <span>&copy; <%: DateTime.Now.Year %> - Landing Constructor<br>All rights and lefts<br>Gudkov P.</span>
                <span><asp:Button ID="Button2" runat="server" OnClick="Button2_Click" class="footer_btn" Text="Сохранить" /></span>
                <span><asp:Button ID="Button1" runat="server" Text="Просмотр" class="footer_btn" OnClick="<%#GetSitePath() %>" Enabled="True" /></span>
            </footer>

<%--            </ContentTemplate>
    </asp:UpdatePanel>--%>
    </div>
</asp:Content>
