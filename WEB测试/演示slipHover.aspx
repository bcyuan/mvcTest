<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="演示slipHover.aspx.cs" Inherits="测试web.演示slipHover" %>

<!DOCTYPE html>
<html lang="zh-CN">
<head>
<meta charset="utf-8">
<title>jQuery插件SlipHover演示-动画时间_dowebok</title>
<style>
#container { width: 900px; margin: 0 auto;}
#container li { display: inline-block; list-style-type: none;}
#container li img { height: 200px; margin: 5px; border: 5px solid #999;}
</style>

    <script src="Scripts/jquery-1.10.2.js"></script>
    <script src="Scripts/jquery.sliphover.js"></script>
<script>
$(function(){
	$('#container').sliphover({
	    duration: 600,
        target:'div'
	});
});
</script>
</head>

<body>
<div class="menu">
	<p class="menuc">
		<span></span>
		<a href="index.html">1、默认</a>
		<a href="index2.html">2、遮罩高度</a>
		<a href="index3.html">3、HTML data属性</a>
		<a class="cur" href="index4.html">4、动画时间</a>
		<a href="index5.html">5、字体颜色</a>
		<a href="index6.html">6、背景颜色</a>
		<a href="index7.html">7、反向</a>
		<a href="index8.html">8、文字排版</a>
		<a href="index9.html">9、禁用链接</a>
	</p>
</div>
<div class="main">
	<div class="mianc">
		<h1>动画时间</h1>

		<!-- Demo start -->
		<div id="container">
			<ul>
				<li>
					<a href="#" target="_blank">
						<img src="img/1.jpg" title="这是一个标题或描述">
					</a>
				</li>
				<li>
					<a href="#" target="_blank">
						<img src="img/1.jpg" title="这里可以放标题或描述">
					</a>
				</li>
				<li>
					<a href="#" target="_blank">
						<img src="img/1.jpg" title="还可以是 HTML 代码">
					</a>
				</li>
				<li>
					<a href="#" target="_blank">
						<img src="img/1.jpg" title="这里可以放标题或描述">
					</a>
				</li>
				<li>
					<a href="#" target="_blank">
						<img src="img/1.jpg" title="这里可以放标题或描述">
					</a>
				</li>
				<li>
					<a href="#" target="_blank">
						<img src="img/1.jpg" title="这里可以放标题或描述">
					</a>
				</li>
				<li>
					<a href="#" target="_blank">
						<img src="img/1.jpg" title="这里可以放标题或描述">
					</a>
				</li>
				<li>
					<a href="#" target="_blank">
						<img src="img/1.jpg" title="这里可以放标题或描述">
					</a>
				</li>
				<li>
					<a href="#" target="_blank">
						<img src="img/1.jpg" title="这里可以放标题或描述">
					</a>
				</li>
				<li>
                    <div>
					<a href="#" target="_blank">
						<img src="img/1.jpg" title="这里可以放标题或描述">
					</a>
                        </div>
				</li>
			</ul>
            <div style="width:100px;height:100px;border:1px red solid">
                <a>4</a>
            </div>
		</div>
		<!-- Demo end -->

        <p class="vad">
            <a href="#" target="_blank">dowebok.com</a>
            <a href="#109.html" target="_blank">说 明</a>
            <a href="#109.html" target="_blank">下 载</a>
        </p>
	</div>
</div>










<!-- 以下是统计及其他信息，与演示无关，不必理会 -->
<style>
* { margin: 0; padding: 0;}
html, body { height: 100%; overflow: hidden;}
body { font-family: Consolas,arial,"宋体";}
.menu { position: absolute; left: 0; top: 0; width: 200px; height: 100%; background-color: #ccc; font-family: Consolas,arial,"宋体";}
.menuc { height: 100%; overflow-x: hidden; overflow-y: auto;}
.menu span { display: block; height: 100px;}
.menu a { display: block; height: 40px; margin: 0 0 1px 2px; padding-left: 10px; line-height: 40px; font-size: 14px; color: #333; text-decoration: none;}
.menu a:hover { background-color: #eee;}
.menu .cur { color: #000; background-color: #fff !important;}
.main { height: 100%; margin-left: 200px;}
.mianc { position: relative; height: 100%; overflow-x: hidden; overflow-y: auto;}
.main h1 { width: 900px; margin: 40px auto; font: 32px "Microsoft Yahei";}
.explain, .dowebok-explain { margin-top: 20px; font-size: 14px; text-align: center; color: #f50;}

.vad { margin: 50px 0 5px; font-family: Consolas,arial,宋体,sans-serif; text-align:center;}
.vad a { display: inline-block; height: 36px; line-height: 36px; margin: 0 5px; padding: 0 50px; font-size: 14px; text-align:center; color:#eee; text-decoration: none; background-color: #222;}
.vad a:hover { color: #fff; background-color: #000;}
.thead { width: 728px; height: 90px; margin: 0 auto; border-bottom: 40px solid #fff;}

.code { position: relative; margin-top: 100px; padding-top: 41px;}
.code h3 { position: absolute; top: 0; z-index: 10; width: 100px; height: 40px; font: 16px/40px "Microsoft Yahei"; text-align: center; cursor: pointer;}
.code .cur { border: 1px solid #f0f0f0; border-bottom: 1px solid #f8f8f8; background-color: #f8f8f8;}
.code .h31 { left: 0;}
.code .h32 { left: 102px;}
.code .h33 { left: 204px;}
.code .h34 { left: 306px;}
.code { width: 900px; margin-left: auto; margin-right: auto;}
pre { padding: 15px 0; border: 1px solid #f0f0f0; background-color: #f8f8f8;}
.f-dn { display: none;}
</style>

</body>
</html>
