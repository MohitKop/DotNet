<%@ Page Language="C#" AutoEventWireup="true" CodeFile="welcome.aspx.cs" Inherits="welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Welcome<br />
            <br />
            <asp:Button ID="logtxt" runat="server" OnClick="logtxt_Click" Text="Login User" Width="200px" />
            <br />
            <br />
            <asp:Button ID="regtxt" runat="server" OnClick="regtxt_Click" Text="Register User" Width="200px" />
        </div>
    </form>
    <p>
        <br />
    </p>
</body>
</html>
