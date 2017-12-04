<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="测试web.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <script src="Scripts/jquery-1.10.2.min.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label class="btnToggle">修改</label>
            <input class="ipt_edit" />
            <p class="pc">
                wojiushiquanbu 
            </p>
             <p>
                axiba 
            </p>
        </div>
    </form>
</body>
</html>
<script>
    $(function myfunction()     {
        // $(".pc").toggle(false);
        $(".ipt_edit").toggle(false);
        $(".btnToggle").on("click", function () {
            //$(".pc").toggle(200);
            $(".ipt_edit").toggle(200);
        })
    })

</script>
