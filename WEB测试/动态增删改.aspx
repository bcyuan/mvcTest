<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="动态增删改.aspx.cs" Inherits="测试web.动态增删改" %>


<!doctype html>
<html>
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>jQuery表格数据增删改插件 Tabullet.js</title>
    <link rel="stylesheet" type="text/css" href="http://www.jq22.com/jquery/bootstrap-3.3.4.css">
    <script src="http://www.jq22.com/jquery/jquery-1.10.2.js"></script>
    <script src="Scripts/Tabullet.js"></script>
    <style>
    body {
        background-color: #fafafa;
    }

    .container {
        margin: 150px auto;
    }
    </style>
    <script>
    $(function() {
        var source = [{
            id: 1,
            name: "Aditya Purwa",
            level: "Admin"
        }, {
            id: 2,
            name: "Aditya Avaga",
            level: "Manager"
        }, {
            id: 101,
            name: "Aditya Myria",
            level: "User"
        }, {
            id: 102,
            name: "Lucent Serentia",
            level: "LOD"
        }, {
            id: 103,
            name: "Hayden Bapalthiel",
            level: "King"
        }];

        function resetTabullet() {
            $("#table").tabullet({
                data: source,
                action: function(mode, data) {
                    console.dir(mode);
                    if (mode === 'save') {
                        source.push(data);
                    }
                    if (mode === 'edit') {
                        for (var i = 0; i < source.length; i++) {
                            if (source[i].id == data.id) {
                                source[i] = data;
                            }
                        }
                    }
                    if (mode === 'delete') {
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
    </script>
</head>

<body>
<div class="container">
    <div class="row">
        <div class="col-sm-12">
            <h1>jQuery Tabullet Plugin Example</h1>
        </div>
    </div>
    <div class="row">
        <div class="col-sm-12">
            <table class="table table-hover" id="table">
                <thead>
                    <tr data-tabullet-map="id">
                        <th width="50" data-tabullet-map="_index" data-tabullet-readonly="true">编号</th>
                        <th data-tabullet-map="name">项目</th>
                        <th data-tabullet-map="level">分数</th>
                        <th width="50" data-tabullet-type="edit"></th>
                        <th width="50" data-tabullet-type="delete"></th>
                    </tr>
                </thead>
            </table>
        </div>
    </div>
</div>
</body>
</html>

