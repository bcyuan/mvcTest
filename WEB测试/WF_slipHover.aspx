<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WF_slipHover.aspx.cs" Inherits="测试web.WF_slipHover" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <script src="Scripts/jquery-1.10.2.js"></script>
    <script src="Scripts/自制js插件.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <ul>
                <li>
                    <a href="http://www.webo.com/liuwayong">我的微博</a>
                </li>
                <li>
                    <a href="http://http://www.cnblogs.com/Wayou/">我的博客</a>
                </li>
                <li>
                    <a href="http://wayouliu.duapp.com/">我的小站</a>
                </li>
            </ul>
            <p>这是p标签不是a标签，我不会受影响</p>
        </div>
    </form>
</body>
</html>

<script>

    var foo = function () {
        //别人的代码
    }//注意这里没有用分号结尾

    ;(function () {
        //我们的代码。。
        //alert('Hello!');
    })();

    $(function () {
        $('a').myPlugin({
            'color': '#2C9929',
            'fontSize': '20px',
            'textDecoration': 'underline'
        });
    })
</script>
