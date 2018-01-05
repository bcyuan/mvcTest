//js版的字典表，用于不常配置的常量字典表。比如1-7对应周一到周日
; (function ($, window, document, undefined) {
    //调用dicer
    $.fn.bydic = function (options) {
        debugger
        var dic0, dic1;
        var newdic = new Array();
        var arrdata = {
            options_num_a: [['1', '2', '3', '4'], ['a', 'b', 'c', 'd']],
            options_num_A: [['1', '2', '3', '4'], ['A', 'B', 'C', 'D']],
            gender_num_zh: [['0', '1'], ['男', '女']]
        };
        var optionsDefault = {
            arr_options_data: arrdata
        }
        var settings = $.extend({}, optionsDefault, options);
        var $this = $(".bydic");
        return $this.each(function (index, ele) {
            var type = $(ele).data("bydic");
            changeAarry(ele, type);
        });
        function changeAarry(ele, type) {
            
            dic0 = settings.arr_options_data[type][0];
            dic1 = settings.arr_options_data[type][1];
            for (var i = 0; i < dic0.length && i < dic0.length; i++) {
                newdic[dic0[i]] = dic1[i];
            }
            $(ele).html(newdic[$(ele).html()]);
        }
    }
})(jQuery, window, document);