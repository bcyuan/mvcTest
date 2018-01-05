<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WF_validate.aspx.cs" Inherits="测试web.WF_validate" %>

<%--2017年10月11日下载的validate.js并测试--%>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <title>jQuery validation plug-in - main demo</title>
    <link href="Style/screen.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.10.2.min.js"></script>
    <script src="Scripts/jquery.validate.js"></script>
    <script src="Scripts/messages_zh.js"></script>
    <script>
        //$.validator.setDefaults({
        //    submitHandler: function () {

        //        alert("submitted--11111");
        //        //form.submit();
        //    }
        //});

        //$().ready(function () {
        //    // 自定义提示语
        //    debugger
        //   var g= $("#commentForm").validate();
        //  var o=  $("#signupForm").validate();

        //});

        function tj2() {
          var cc=  $("#signupForm").validate();
            
        }

    </script>
    
    
</head>
<body>
    
    <div id="main" >
        <p>Default submitHandler is set to display an alert into of submitting the form</p>
        <form  id="commentForm" style="width: 70%">
                
                <p>
                    <label for="cname">Name (required)</label>
                    <%-- <input id="cname" name="Fname" type="text" isinteqzero="true">--%>
                    <%--<input id="cname" name="username" type="text" required>--%>
                    <%--<input id="cname" name="math" type="text" number="true" >--%>
                    <%--<input id="cname" name="name" type="text" number="true" range="[3,5]">--%>
                </p>
                <label for="field">Required, minium 13, maximum 23:</label>
                <input type="text" class="left" id="math" required>
                <input id="cname" number="true" maxdecimalplace="2">
                <p>
                    <label for="cemail">E-Mail (required)</label>
                    <input id="cemail" type="email" name="email">
                </p>
                <div>
                    <button>dianj</button>
                </div>
               
            
        </form>

        <form class="cmxform" id="signupForm" method="get" action="">
            <input type="text" class="left"  required>
            <input type="text" class="left" required>
            <button onclick="tj2()">提交二</button>
        </form>
    </div>
</body>
</html>

