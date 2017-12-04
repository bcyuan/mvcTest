<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="测试web.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="Scripts/bootstrap-3.3.7-dist/css/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.10.2.min.js"></script>
    <script src="Scripts/MyJS.js"></script>
    <script src="Scripts/自制js插件.js"></script>
    <title></title>
    <style>
        

        .content-wrapper {
            background: #fff;
            height: 100%;
            margin-top: 0;
            margin-bottom: 0;
            position: relative;
            height: 830px;
            margin-left: 240px;
        }

        .iframediv {
            margin: 10px 10px 0px;
            padding: 0px;
            height: 730.222px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="panel-body">
        <div class="row">

            <div class=" navM" style="height: 730.222px;">
                <div class="text-success h2 bg-success text-muted btn-warning">
                    测试1
                </div>
                <div class=" h2 lead">
                    测试2
                </div>
                <div id="ceshi" class="Mycss">
                    jjjjjj
                    <p>ppppppp</p>
                </div>
            </div>

            <div class="content-wrapper ">
                <div style="overflow: hidden;">
                    <div class="iframediv">
                        <%--<iframe width="100%" height="100%" src="iframe.aspx"></iframe>--%>
                    </div>
                </div>
            </div>

        </div>
    </form>
</body>
</html>
<script>
    $(function () {
        var i = 100; j = 101;
        var min_v = $.minValue(i, j); // min_v 等于 100
        var max_v = $.maxValue(i, j); // max_v 等于 101
        var max_s = $.ceshi(i, j, 100); // max_v 等于 101

    })
</script>


<script>
    $(function () {
        var optionsM = {
            color: 'blue'
        };
        //$(".Mycss").treeview();//直接调用
        $(".Mycss").treeview({
            options: optionsM
        });//覆盖默认配置调用
    });
</script>
