<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Homepage.aspx.cs" Inherits="Homepage" %>

<!DOCTYPE html>

<script runat="server">
    protected void Page_Load(object sender, EventArgs e)
    {
        lblServerDateTime.Text = DateTime.Now.ToString();
    }

</script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            WELCOME<br />
            <br />
        </div>
        <p>
            <asp:TextBox ID="lblServerDateTime" runat="server"></asp:TextBox>
        </p>
    </form>
</body>
</html>
