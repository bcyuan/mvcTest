<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="暂时测试.aspx.cs" Inherits="测试web.暂时测试" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script src="Scripts/jquery-1.10.2.js"></script>
    <script src="Scripts/bootstrap/bootstrap.js"></script>
    <link href="Scripts/bootstrap/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="ceshi">
            <div>ceshi1</div>
            <div>ceshi2</div>
            <div>ceshi3</div>
            <div class="ceshi2">
                <div>ceshi4</div>
                <div>ceshi5</div>
                <div>ceshi6</div>
            </div>
        </div>
        <div class="ceshi2">
            <div>ceshi7</div>
            <div>ceshi8</div>
            <div>ceshi9</div>
        </div>
        <div class="ceshi13">
            <input type="checkbox" value="1" checked="checked" />
            <input type="checkbox" value="2" />
            <input type="checkbox" value="3" />
            <input type="checkbox" value="4" />
            <div class="ceshi3">
                3
            </div>
        </div>
        <div class="container-fluid">
            <div class="form-inline">
                <div  class="form-group">
                    <input />
                </div>
                <div  class="form-group">
                    <input />
                </div>
            </div>
        </div>

    </form>
    <div class="form-inline">
        <div class="form-group">
            <label for="exampleInputName2">Name</label>
            <input type="text" class="form-control" id="exampleInputName2" placeholder="Jane Doe"/>
        </div>
        <div class="form-group">
            <label for="exampleInputEmail2">Email</label>
            <input type="email" class="form-control" id="exampleInputEmail2" placeholder="jane.doe@example.com"/>
        </div>
        <button type="submit" class="btn btn-default">Send invitation</button>
    </div>
</body>
</html>
<script>
    debugger
    var numbers = [4, 9, 16, 25];
  var cc=  numbers.map(Math.sqrt);
   var bb= numbers.map(function (item) {
       return item + 1;
    });
</script>
