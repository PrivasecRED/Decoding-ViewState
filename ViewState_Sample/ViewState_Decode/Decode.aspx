<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Decode.aspx.cs" Inherits="ViewState_Decode.Decode" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtViewState" runat="server" TextMode="MultiLine" Height="500" Width="500"></asp:TextBox>
        <asp:Button ID="btnDecode" runat="server" Text="Button" OnClick="btnDecode_Click" />
    </div>
        
    </form>
    <asp:Label ID="lblDecodedString" runat="server" Text="Label"></asp:Label>
</body>
</html>
