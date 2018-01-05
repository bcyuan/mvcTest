<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="测试自制树表.aspx.cs" Inherits="测试web.测试自制树表" %>





<!doctype html>
<html>
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>jQuery表格数据增删改插件 Tabullet.js</title>
    <link rel="stylesheet" type="text/css" href="http://www.jq22.com/jquery/bootstrap-3.3.4.css">
    <script src="http://www.jq22.com/jquery/jquery-1.10.2.js"></script>
<%--    <script src="Scripts/Tabullet.js"></script>--%>
    <style>
        body {
            background-color: #fafafa;
        }

        .container {
            margin: 150px auto;
        }
    </style>
    
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
                    <tbody>
                        <tr data-tabullet-id="-1">
                            <td></td>
                            <td>
                                <input type="text" name="name" class="form-control"></td>
                            <td>
                                <input type="text" name="level" class="form-control"></td>
                            <td data-tabullet-type="save">
                                <button class="btn btn-success">Save</button></td>
                            <td></td>
                        </tr>
                        <tr data-tabullet-id="1">
                            <td data-tabullet-map="_index" data-tabullet-readonly="true">0</td>
                            <td data-tabullet-map="name">Aditya Purwa</td>
                            <td data-tabullet-map="level">Admin</td>
                            <td data-tabullet-type="edit">
                                <button class="btn btn-default">Edit</button></td>
                            <td data-tabullet-type="delete">
                                <button class="btn btn-danger">Delete5</button></td>
                        </tr>
                        
                        <tr>
                            <td colspan="4">
                            <table class="table table-hover" id="tttt">
                                <tbody>
                                <tr data-tabullet-id="101">
                                    <td data-tabullet-map="_index" data-tabullet-readonly="true">2</td>
                                    <td data-tabullet-map="name">Aditya Myria</td>
                                    <td data-tabullet-map="level">User</td>
                                    <td data-tabullet-type="edit">
                                        <button class="btn btn-default">Edit</button></td>
                                    <td data-tabullet-type="delete">
                                        <button class="btn btn-danger">Delete</button></td>
                                </tr>
                                <tr data-tabullet-id="101">
                                    <td data-tabullet-map="_index" data-tabullet-readonly="true">2</td>
                                    <td data-tabullet-map="name">Aditya Myria</td>
                                    <td data-tabullet-map="level">User</td>
                                    <td data-tabullet-type="edit">
                                        <button class="btn btn-default">Edit</button></td>
                                    <td data-tabullet-type="delete">
                                        <button class="btn btn-danger">Delete</button></td>
                                </tr>
                                <tr data-tabullet-id="101">
                                    <td data-tabullet-map="_index" data-tabullet-readonly="true">2</td>
                                    <td data-tabullet-map="name">Aditya Myria</td>
                                    <td data-tabullet-map="level">User</td>
                                    <td data-tabullet-type="edit">
                                        <button class="btn btn-default">Edit</button></td>
                                    <td data-tabullet-type="delete">
                                        <button class="btn btn-danger">Delete</button></td>
                                </tr>
                                </tbody>
                            </table>
                            </td>
                        </tr>
                        <tr data-tabullet-id="2">
                            <td data-tabullet-map="_index" data-tabullet-readonly="true">1</td>
                            <td data-tabullet-map="name">Aditya Avaga</td>
                            <td data-tabullet-map="level">Manager</td>
                            <td data-tabullet-type="edit">
                                <button class="btn btn-default">Edit</button></td>
                            <td data-tabullet-type="delete">
                                <button class="btn btn-danger">Delete</button></td>
                        </tr>
                        <tr data-tabullet-id="101">
                            <td data-tabullet-map="_index" data-tabullet-readonly="true">2</td>
                            <td data-tabullet-map="name">Aditya Myria</td>
                            <td data-tabullet-map="level">User</td>
                            <td data-tabullet-type="edit">
                                <button class="btn btn-default">Edit</button></td>
                            <td data-tabullet-type="delete">
                                <button class="btn btn-danger">Delete</button></td>
                        </tr>
                        <tr data-tabullet-id="102">
                            <td data-tabullet-map="_index" data-tabullet-readonly="true">3</td>
                            <td data-tabullet-map="name">Lucent Serentia</td>
                            <td data-tabullet-map="level">LOD</td>
                            <td data-tabullet-type="edit">
                                <button class="btn btn-default">Edit</button></td>
                            <td data-tabullet-type="delete">
                                <button class="btn btn-danger">Delete</button></td>
                        </tr>
                        <tr data-tabullet-id="103">
                            <td data-tabullet-map="_index" data-tabullet-readonly="true">4</td>
                            <td data-tabullet-map="name">Hayden Bapalthiel</td>
                            <td data-tabullet-map="level">King</td>
                            <td data-tabullet-type="edit">
                                <button class="btn btn-default">Edit</button></td>
                            <td data-tabullet-type="delete">
                                <button class="btn btn-danger">Delete</button></td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</body>
</html>

