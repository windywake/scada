﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="Scada.Web.WFrmError" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>Application Error - Rapid SCADA</title>
    <link href="~/images/favicon.ico" rel="shortcut icon" type="image/x-icon" />
    <link href="~/lib/open-sans/css/open-sans.css" rel="stylesheet" type="text/css" />
    <link href="~/css/error.min.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <div id="divHeader">Rapid SCADA</div>
    <div id="divContent">
        <h1><asp:Label ID="lblTitle" runat="server" Text="Application Error"></asp:Label></h1>
        <div class="error"><asp:Label ID="lblErrMsg" runat="server" Text="An application error occurred. If it repeats often, please contact the support."></asp:Label></div>
        <div class="error"><asp:Label ID="lblErrDetailsCaption" runat="server" Text="Details:"></asp:Label><br />
            <asp:Label ID="lblErrDetails" runat="server" Text=""></asp:Label></div>
    </div>
</body>
</html>
