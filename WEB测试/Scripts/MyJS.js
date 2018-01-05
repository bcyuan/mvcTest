//扩展jQuery对象本身
jQuery.extend({
    "minValue": function (a, b) {
        ///<summary>
        /// 比较两个值，返回最小值
        ///</summary>
        return a < b ? a : b;
    },
    "maxValue": function (a, b) {
        ///<summary>
        /// 比较两个值，返回最大值
        ///</summary>
        return a > b ? a : b;
    }
});

jQuery.extend({
    "ceshi": function (a, b, c) {
        return a + b + c;
    }
})
