<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="select2多选.aspx.cs" Inherits="测试web.select2多选" %>

<html>
<head>
    <title></title>
    <meta charset="utf-8">
    
    <script src="Scripts/jquery-1.3.2.min.js"></script>
    <script>
        var $ = $.noConflict(true);
    </script>
    <script src="http://libs.baidu.com/jquery/1.9.0/jquery.js"></script>
     <script>
         var $190 = $.noConflict(true);
    </script>
    <link href="Scripts/select2/select2.css" rel="stylesheet" />
    <script src="Scripts/select2/select2.js"></script>
    <script src="Scripts/select2/select2_locale_zh-CN.js"></script>
    <script>
        $190(function () {
            $190("#e1").select2();
        })
    </script>
</head>
<body>
    <ul>
        <li>
<select multiple id="e1" style="width: 400px">
        <option selected value="四川">四川</option>
        <option value="山东">山东</option>
        <option selected value="北京">北京</option>
        <option value="上海">上海</option>
        <option selected value="江苏">江苏</option>
        <option value="杭州">杭州</option>
    </select>
        </li>
    </ul>
    

    <input type='button' value='显示结果' id="btn" style="margin-left: 100px" />

    <h2>意思是多值选择框最多可以选择的个数是多少，这里是3个。</h2>
</body>
</html>
