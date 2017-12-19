<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="压缩文件2.aspx.cs" Inherits="测试web.压缩文件2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script src="Scripts/jquery-1.10.2.js"></script>
    <script src="Scripts/bootstrap/bootstrap.js"></script>
    <link href="Scripts/bootstrap/bootstrap.min.css" rel="stylesheet" />
    <style>
        .upload div {
            margin: 25px;
            line-height: 20px;
        }

        .uploadc {
            float: left;
            width: 45%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="upload">
            <div><span>填写检测报告编号</span><input type="text" /></div>
            <div><span class="uploadc">上传检测报告</span><input class="uploadc" type="file" /></div>
            <a class="imageName" href="https://exp.bdstatic.com/static/common-jquery/widget/search-box/img/logo_83ae7e2.png"></a>
            <img class="qr_img" src="https://exp.bdstatic.com/static/common-jquery/widget/search-box/img/logo_83ae7e2.png" alt="Alternate Text" />
        </div>
        
        <input type="button" name="name" value="input按钮 " onclick="download(2)" />
    </form>
    <div class="down_qr">666666</div>
    <input class="sutmit_btn" type="button" value="baocun" />

</body>
</html>
<script>

        var numbers = [4, 9, 16, 25];
        var cc = numbers.map(Math.sqrt);
        var bb = numbers.map(function (item) {
            return item + 1;
        });

        function ceshi2(id) {
            $.ajax({
                url: "/data/bb.ashx",
                async: false,
                dataType: 'text',
                data: {},
                success: function (data) {
                    debugger
                    grade = data;
                },
                error: function () {
                    debugger
                }
            });
        }

   
</script>

<script type="text/javascript">
    function download() {
        DownloadFileByIframe("/data/bb.ashx");
    }

    function DownloadFileByIframe(url) {
        var iframe = document.getElementById("TempCreatedIframeElement");

        if (iframe == null) {
            iframe = document.createElement("iframe");
            iframe.id = "TempCreatedIframeElement";
        }

        iframe.style.display = "none";
        document.body.appendChild(iframe);
        iframe.src = url;
    }
</script>
