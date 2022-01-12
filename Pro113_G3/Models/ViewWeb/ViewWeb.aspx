<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewWeb.aspx.cs" Inherits="Pro113_G3.Models.ViewWeb.ViewWeb" %>

<%@ Register src="UCHitCounter.ascx" tagname="UCHitCounter" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <uc1:UCHitCounter ID="UCHitCounter1" runat="server" />
    </form>
</body>
</html>
