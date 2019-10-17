<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication1.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-1.10.2.min.js"></script>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="text-center">
            <asp:Label runat="server" ID="name"></asp:Label><br />
            <asp:Label runat="server" ID="desc"></asp:Label><br />
            <asp:Button runat="server" ID="btn_approve" Text="Approve" CssClass="btn btn-success"/>
            <asp:Button runat="server" ID="btn_decline" Text="Decline" CssClass="btn btn-danger"/>
        </div>
    </form>
</body>
</html>
