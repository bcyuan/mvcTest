<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="测试Table合并.aspx.cs" Inherits="测试web.测试Table合并" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <%--<link href="Scripts/tabelsMergeCell/base.css" rel="stylesheet" />--%>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table id="process-demo-1" class="tb tb-b c-100 c-t-center">
                <tr class="tab1">
                    <th>时间</th>
                    <th>企业</th>
                    <th>产品</th>
                    <th>规格</th>
                    <th>重量</th>
                    <th>数量</th>
                    <th>签约备注</th>
                    <th>状态</th>
                </tr>
                <tr class="tab2">
                    <td>2017年11月30日</td>
                    <td>安徽嘉德纺织有限公司</td>
                    <td>A级盖棉胎</td>
                    <td>2100mm*1500mm</td>
                    <td>5000kg</td>
                    <td>5000kg</td>
                    <td>2.5kg/床</td>
                    <td>签约成功-已备案</td>
                </tr>

                <tr class="tab2">
                    <td>2017年11月30日</td>
                    <td>安徽嘉德纺织有限公司</td>
                    <td>A级盖棉胎</td>
                    <td>2100mm*1500mm</td>
                    <td>5000kg</td>
                    <td>2000床</td>
                    <td>2.5kg/床</td>
                    <td>签约成功-已备案</td>
                </tr>
                <tr class="tab2">
                    <td>2017年11月31日</td>
                    <td>安徽嘉德纺织有限公司</td>
                    <td>B级盖棉胎</td>
                    <td>2100mm*1500mm</td>
                    <td>4000kg</td>
                    <td>2000床</td>
                    <td>2kg/床</td>
                    <td>签约成功-已备案</td>
                </tr>
                <tr class="tab2">
                    <td>2017年11月31日</td>
                    <td>安徽嘉德纺织有限公司2</td>
                    <td>B级盖棉胎</td>
                    <td>2100mm*1500mm</td>
                    <td>4000kg</td>
                    <td>2000床</td>
                    <td>2kg/床</td>
                    <td>签约成功-已备案</td>
                </tr>
                <tr class="tab2">
                    <td>2017年11月31日</td>
                    <td>安徽嘉德纺织有限公司2</td>
                    <td>B级盖棉胎</td>
                    <td>2100mm*1500mm</td>
                    <td>4000kg</td>
                    <td>2000床</td>
                    <td>2kg/床</td>
                    <td>签约成功-已备案</td>
                </tr>
                <tr class="tab2">
                    <td>2017年11月31日</td>
                    <td>安徽嘉德纺织有限公司2</td>
                    <td>B级盖棉胎</td>
                    <td>2100mm*1500mm</td>
                    <td>4000kg</td>
                    <td>2000床</td>
                    <td>2kg/床</td>
                    <td>签约成功-已备案</td>
                </tr>
                <tr class="tab2">
                    <td>2017年11月31日</td>
                    <td>安徽嘉德纺织有限公司3</td>
                    <td>B级盖棉胎</td>
                    <td>2100mm*1500mm</td>
                    <td>4000kg</td>
                    <td>2000床</td>
                    <td>2kg/床</td>
                    <td>签约成功-已备案</td>
                </tr>
                <tr class="tab2">
                    <td>2017年11月31日</td>
                    <td>安徽嘉德纺织有限公司3</td>
                    <td>B级盖棉胎</td>
                    <td>2100mm*1500mm</td>
                    <td>4000kg</td>
                    <td>2000床</td>
                    <td>2kg/床</td>
                    <td>签约成功-已备案</td>
                </tr>
                <tr class="tab2">
                    <td>2017年11月31日</td>
                    <td>安徽嘉德纺织有限公司3</td>
                    <td>B级盖棉胎</td>
                    <td>2100mm*1500mm</td>
                    <td>4000kg</td>
                    <td>2000床</td>
                    <td>2kg/床</td>
                    <td>签约成功-已备案</td>
                </tr>
                <tr class="tab2">
                    <td>2017年11月31日</td>
                    <td>安徽嘉德纺织有限公司3</td>
                    <td>B级盖棉胎</td>
                    <td>2100mm*1500mm</td>
                    <td>4000kg</td>
                    <td>2000床</td>
                    <td>2kg/床</td>
                    <td>签约成功-已备案</td>
                </tr>
            </table>
        </div>
        <hr />
         
    </form>
</body>
</html>

<script src="Scripts/tabelsMergeCell/jquery.js"></script>
<script src="Scripts/tabelsMergeCell/tablesMergeCell.js"></script>
<script type="text/javascript">
    $(function () {
        $('#process-demo-1').tablesMergeCell({
            cols: [0]
        });

        //$('#process-demo-2').tablesMergeCell({
        //    cols: [0, 1, 7]
        //});

        //$('#process-demo-3').tablesMergeCell({
        //    automatic: false,
        //    cols: [0, 3],
        //    rows: [[3, 4, 5], [6, 7]]//第0列的345行，第3列的67行合并
        //});
    });
</script>
