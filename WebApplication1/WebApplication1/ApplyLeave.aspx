<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ApplyLeave.aspx.cs" Inherits="WebApplication1.ApplyLeave" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-1.10.2.min.js"></script>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery.signalR-2.4.1.min.js"></script>
    <script src="signalr/hubs" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {

            var IWannaChat = $.connection.myChatHub;

            IWannaChat.client.addMessage = function (message) {
                $('#listMessages').append('<li>' + message + '</li>');
            };

            $("#SendMessage").click(function () {
                IWannaChat.server.send($('#txtMessage').val());
            });

            $.connection.hub.start();
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container text-center" style="margin-top:50px">
            <asp:TextBox runat="server" ID="textbox1"></asp:TextBox><br />
            <asp:TextBox runat="server" ID="textbox2"></asp:TextBox><br />
            <asp:Button runat="server" ID="btn_apply" Text="Apply Leave" CssClass="btn btn-success" OnClick="btn_apply_Click"/>
        </div>
        <div class="container text-center">
            <input type="text" id="txtMessage" />
            <input type="button" id="SendMessage" value="broadcast" />
            <ul id="listMessages">
            </ul>
        </div>
    </form>
</body>
</html>
