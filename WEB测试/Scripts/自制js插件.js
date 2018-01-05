/*
注：1,命名：jquery.{diy}.js         
2, “jQuery.fn”是“jQuery.prototype”的简写  
3,自执行匿名函数(function(){代码})();防止污染全局命名空间，同时不会和别的代码冲突；
4,我们在代码开头加一个分号,防止别人使用时，别人的代码方法后没有分号而导致出错；
5最后我们得到一个非常安全结构良好的代码：加入window等是防止这些全局变量被别人污染；
    ; (function ($, window, document, undefined) {
        //我们的代码。。
        //blah blah blah...
    })(jQuery, window, document);
6,当变量是jQuery类型时，建议以$开头,如：var $element=$('a');
7,题外话：一般HTML代码里面使用双引号，而在JavaScript中多用单引号
8,$.fn[pluginName]和$.fn.pluginName写法不同，意义相同
*/
//1、封装对象方法的插件，例如wdtree
//闭包限定命名空间
; (function ($) {
    $.fn.treeview = function (settings) {
        debugger
        var dfop = {
            color: '#ff9966'
        };
        var opts = $.extend({}, dfop, settings.options);//覆盖默认配置,注：新的空对象做为$.extend的第一个参数，defaults和用户传递的参数对象紧随其后，这样做的好处是所有值被合并到这个空对象上，保护了插件里面的默认值。
        return this.each(function () {      //加return可以使自定义的方法支持$链式调用
            var $this = $(this);
            $this.css({
                color: opts.color
            });
        });
    }
})(jQuery);
//2、封装全局函数的插件,eg：jquery.validate.js

//闭包限定命名空间
; (function ($) {
    $.extend($.fn, {
        valid: function (a) {

        }
    });
})(jQuery);

//-----------------------------------------sliphover-----------------------------------------
; (function ($, window, document, undefined) {
    //定义Beautifier的构造函数
    var Beautifier = function (ele, opt) {
        this.$element = ele,
        this.defaults = {
            'color': 'red',
            'fontSize': '12px',
            'textDecoration': 'none'
        },
        this.options = $.extend({}, this.defaults, opt)
    }
    //定义Beautifier的方法
    Beautifier.prototype = {
        beautify: function () {
            return this.$element.css({
                'color': this.options.color,
                'fontSize': this.options.fontSize,
                'textDecoration': this.options.textDecoration
            });
        }
    }
    //在插件中使用Beautifier对象
    $.fn.myPlugin = function (options) {
        //创建Beautifier的实体
        var beautifier = new Beautifier(this, options);
        //调用其方法
        return beautifier.beautify();
    }
    //多个变量只需要一个var关键字就行了
    var c = 3,b = 5;
})(jQuery, window, document);

