<%@ Page Language="C#" MasterPageFile="~/AdminPage.Master" AutoEventWireup="true" CodeFile="CommonProp.aspx.cs" Inherits="CommonProp" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <div class="bs-docs-header-request" id="content" tabindex="-1"> 
        <h1>Заявка на оказание услуг</h1> 
    </div>

    <div class="box_request">
        <div >
            <label>Имя</label>
            <br/>
            <asp:TextBox ID="TextBox1" runat="server" class="little_input_request" placeholder="Как к вам обращаться"></asp:TextBox>
        </div>
        <div >
            <label>Телефон</label>
            <br/>
            <asp:TextBox ID="TextBox2" runat="server" class="phone_mask little_input_request" placeholder="Ваш номер телефона"></asp:TextBox>
        </div>
        <div >
            <label>Комментарий</label>
            <br/>
            <asp:TextBox ID="TextBox3" runat="server" class="big_input_request" placeholder="Комментарий"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Отправить" class="usual_btn_request" OnClick="Button1_Click" />
        </div>
    </div>
        <script>
window.addEventListener("DOMContentLoaded", function() {
function setCursorPosition(pos, elem) {
    elem.focus();
    if (elem.setSelectionRange) elem.setSelectionRange(pos, pos);
    else if (elem.createTextRange) {
        var range = elem.createTextRange();
        range.collapse(true);
        range.moveEnd("character", pos);
        range.moveStart("character", pos);
        range.select()
    }
}

function mask(event) {
    var matrix = "+7 (___) ___-__-__",
        i = 0,
        def = matrix.replace(/\D/g, ""),
        val = this.value.replace(/\D/g, "");
    if (def.length >= val.length) val = def;
    this.value = matrix.replace(/./g, function(a) {
        return /[_\d]/.test(a) && i < val.length ? val.charAt(i++) : i >= val.length ? "" : a
    });
    if (event.type == "blur") {
        if (this.value.length == 2) this.value = ""
    } else setCursorPosition(this.value.length, this)
};
    var input = document.querySelector("#MainContent_TextBox2");
    input.addEventListener("input", mask, false);
    input.addEventListener("focus", mask, false);
    input.addEventListener("blur", mask, false);
});
  </script>
</asp:Content>
