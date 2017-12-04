<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="学习插件.aspx.cs" Inherits="测试web.学习插件" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="Style/screen.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.10.2.min.js"></script>
    <script src="Scripts/jquery.validate.js"></script>
    <script src="Scripts/messages_zh.js"></script>

</head>
<script type="text/javascript">

    $().ready(function () {
        $("#signupForm").validate({
            submitHandler: function (form) {
                alert("submitted");
            }
        });
        $("#signupForm2").validate({
            submitHandler: function (form) {
                alert("submitted2");
            },
            ignore: ".ignore"
        });
        $("#beddingList").validate();

    });
    function addBedding() {
        debugger
        $("#beddingList").validate({
            //submitHandler: function (form) {
            //    $("#beddingList").append("<tr class='beddingTr'><td class='formvalue beddingA'>dd</td><td class='beddingB'>66</td><td><span class='minusBedding glyphicon glyphicon-minus'></span></td></tr>");
            //}
            success:function () {
                alert(3);
            }
        });

    }

</script>
<body>
    <form id="signupForm" method="get" action="">
        <p>
            <label for="firstname">Firstname</label>
            <input  name="firstname" required />
        </p>
        <p>
            <input class="submit" type="submit" value="Submit" />
        </p>
    </form>
    <form id="signupForm2" method="get" action="">
        <p>
            <label for="firstname">Firstname</label>
            <input id="firstname" name="firstname" class="required" />
        </p>
        <p>
            <input class="submit" type="submit" value="Submit" />
        </p>
        <table class="ceshi ignore" id="beddingList" style="width: 250px;">
            <tr style="border-bottom: none;">
                <td>
                    <input id="beddingName" class="form-control required " placeholder="卧具名" /></td>
                <td class="text-center gray">—</td>
                <td class="formValue">
                    <input id="beddingCount" class="form-control" placeholder="数量"  /></td>
                <td style="padding-left: 10px;"><input class="submit" type="submit" onclick="addBedding()" value="新增" /></td>
            </tr>
        </table>
    </form>

</body>
</html>

