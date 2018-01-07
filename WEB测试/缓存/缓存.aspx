<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="缓存.aspx.cs" Inherits="WEB测试.缓存.缓存" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button Text="ceshi" runat="server" OnClick="Unnamed1_Click" />
        </div>
    </form>
</body>
</html>
<script src="../Scripts/jquery-1.10.2.js"></script>
<script src="../Content/jquery.cookie.js"></script>
<script>
    $(function () {
        var Hcitys={
            city:['哈尔滨','大庆']
        }
        var province = {
            name: '黑龙江',
            cities: Hcitys
        }
        var china = {
            name: '中国',
            province: province
        }
        debugger
        $.cookie("cookie_areaJonsString", "{{name:'中国',province:[{name:'黑龙江',cities:{city:['哈尔滨','大庆']}}");
        $.cookie("cookie_areaJson", JSON.stringify(china));
        $.cookie("cookie_3", "101,102,103");

        var tmp = $.cookie("cookie_areaJonsString");
        var tmp = $.cookie("cookie_areaJson");
        var tmp = $.cookie("cookie_3");

    })
</script>
