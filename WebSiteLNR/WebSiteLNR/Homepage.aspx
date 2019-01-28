<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Homepage.aspx.cs" Inherits="Homepage" %>

<!DOCTYPE html>

<script runat="server">
    

</script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <asp:Label runat="server" ID="lblUserId" Visible="false"></asp:Label>
            <br />
            <br />
        </div>
        <p>
            <asp:TextBox ID="lblServerDateTime" runat="server" OnTextChanged="lblServerDateTime_TextChanged"></asp:TextBox>
        </p>
    </form>
</body>
</html>
