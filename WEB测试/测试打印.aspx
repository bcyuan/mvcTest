<!DOCTYPE html>
<html class="no-js">
    <head>
        <meta charset="utf-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
        <title>jQuery.Print</title>
        <meta name="description" content="jQuery.print is a plugin for printing specific parts of a page">
        <meta name="viewport" content="width=device-width">
    </head>
    <body>
        <div id="content_holder">
            <div id="ele4" class="b">
                <h3 class='avoid-this'>Element 4</h3>
                <p>
                Some really random text.
                </p>
                打印内容
                <button class="print-link avoid-this" onclick="dayin()">打印</button>
            </div>
            <br/>
        </div>
        <script src="http://www.jq22.com/jquery/jquery-1.7.1.js"></script>
        <script src="Content/jQuery.print.min.js"></script>
        <script type='text/javascript'>
                function dayin() {
                    $("#ele4").print({
                        globalStyles: false,
                        mediaPrint: false,
                        iframe: false,
                        noPrintSelector: ".avoid-this",
                        prepend: "top",
                        append: "bottom",
                        deferred: $.Deferred().done(function () { console.log('Printing done', arguments); })
                    });
                }
        </script>
    </body>
</html>
