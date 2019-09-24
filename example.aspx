<%@ Page language="C#" Codebehind="example.cs" AutoEventWireup="false" Inherits="Example" %>
<html>
<head>
	<title>ArtLebedevStudio.RemoteTypograf example</title>
	<style type="text/css">
		nobr
		{
			background-color: #EEF1E5;
		}
	</style>
</head>
<body>
	<form id="ExampleForm" method="post" runat="server">
		<asp:TextBox TextMode="MultiLine" Width="300" Height="200" Runat="server" ID="Input" Text='"Вы все еще      кое-как верстаете в "Ворде"?   - Тогда мы идем к вам ! "'/>
        <p>
			<asp:Button Runat="server" ID="Proceed" OnClick="Proceed_OnClick" Text="ProcessText"/>
		</p>		
		<div>
			<asp:Literal ID="Output" Runat="server"/>
		</div>
	</form>
</body>
</html>
