<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tabullet演示.aspx.cs" Inherits="测试web.tabullet演示" %>

<!doctype html>
<html>
<head>
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
    <meta content="text/html; charset=utf-8" http-equiv="Content-Type"/>  
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>jQuery表格数据增删改插件 Tabullet.js</title>
    <link rel="stylesheet" type="text/css" href="http://www.jq22.com/jquery/bootstrap-3.3.4.css">
    <script src="http://www.jq22.com/jquery/jquery-1.10.2.js"></script>
    <script charset="utf-8" src="Scripts/Tabullet.js"></script>
    <style>
        body {
            background-color: #fafafa;
        }

        .container {
            margin: 150px auto;
        }
    </style>
    <script>
        var source = [];
        $(function () {
            function resetTabullet() {
                $("#table").tabullet({
                    data: source,
                    action: function (mode, data, $this) {
                        console.dir(mode);
                        if (mode === 'save') {
                            source.push(data);
                        }
                        if (mode === 'edit') {
                            var index = $this.parents("table").find("tr").index($this.parents("tr")) - 2;
                            if (source[index].id == data.id) {
                                source[index] = data;
                            }
                        }
                        if (mode == 'delete') {
                            for (var i = 0; i < source.length; i++) {
                                if (source[i].id == data) {
                                    source.splice(i, 1);
                                    break;
                                }
                            }
                        }
                        resetTabullet();
                    }

                });
            }
            resetTabullet();

        });
        function getTabulletData() {
            debugger
            var cc = source;
        }
    </script>

</head>

<body>
    <div class="container">
        <div class="row">
            <div class="col-sm-12">
                <table class="table table-hover" id="table">
                    <thead style="display:none">
                        <tr data-tabullet-map="id">
                            <%--<th width="50" data-tabullet-map="_index" data-tabullet-readonly="true">No</th>--%>
                            <th data-tabullet-map="name">Nama</th>
                            <th data-tabullet-map="level">Level</th>
                            <th data-tabullet-type="edit"></th>
                            <th data-tabullet-type="delete"></th>
                        </tr>
                    </thead>
                </table>
            </div>
        </div>
        <input type="button"  name="name" value="tj" onclick="getTabulletData()" />
    </div>
</body>
</html>

