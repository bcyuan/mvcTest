//jq22下载改进（添加主键参数bylzf）
; (function ($) {
    $.fn.tablesMergeCell = function (options) {
        var defaultsettings = {
            automatic: true,
            cols: null,        // 用数组表示列的索引,从0开始,然后根据指定列来处理(合并)相同内容单元格
            rows: null,
            key: 0             // 设置主键后，最大合并行数=主键合并行数
        };
        var arr = [];//记录合并行个数的数组
        var opts = $.extend(defaultsettings, options);
        var key = opts.key;
        var cols = opts.cols;
        var rows = opts.rows;
        return this.each(function (){ 

            if (rows == null) {
                for (var i = 0; cols[i] != undefined; i++) {
                    tablesMergeCell($(this), cols[i]);
                }
            } else {
                for (var i = cols.length - 1, k = opts.rows.length - 1; cols[i] != undefined; i--, k--) {
                    tablesMergeCell($(this), cols[i], k);
                }
            }
            dispose($(this));
        });

        // 如果对javascript的closure和scope概念比较清楚, 这是个插件内部使用的private方法
        function tablesMergeCell($table, colIndex, rowIndex) {
            $table.data('col-content', '');     // 存放单元格内容
            $table.data('col-rowspan', 1);      // 存放计算的rowspan值 默认为1
            $table.data('col-td', $());         // 存放发现的第一个与前一行比较结果不同td(jQuery封装过的), 默认一个"空"的jquery对象
            $table.data('trNum', $('tbody tr', $table).length);     // 要处理表格的总行数, 用于最后一行做特殊处理时进行判断之用
            // 我们对每一行数据进行"扫面"处理 关键是定位col-td, 和其对应的rowspan
            var j = 0;//当前列合并总索引
            var m = 0;//当前列合并行数
            $('tbody tr', $table).each(function (index) {
                var $tr = $(this);
                var Ytime = 0;
                // td:eq中的colIndex即列索引
                var $td = $('td:eq(' + colIndex + ')', $tr);
                debugger
                var currentContent = $td.html();
                //if (keyIndex != 1) {debugger}
                if (colIndex != key && arr[j] == m) {
                    j++;
                    m = 0;
                    currentContent = currentContent + "0";
                }
                if (index == $('tbody tr', $table).length - 1) {
                    var sumCount = $('tbody tr', $table).length - 1;
                }

                if (opts.automatic) {//自动内容
                    // 第一次时走此分支
                    if ($table.data('col-content') == '') {
                        $table.data('col-content', currentContent);
                        $table.data('col-td', $td);
                    }
                    else {
                        if (colIndex == key) {//key列
                            if ($table.data('col-content') == currentContent) {
                                //debugger
                                j++;
                                addRowspan();   // 上一行与当前行内容相同则col-rowspan累加, 保存新值
                            } else {
                                arr.push(j);
                                j = 0;
                                newRowspan();   // 上一行与当前行内容不同
                            }
                            if (sumCount == $('tbody tr', $table).length - 1) {
                                arr.push(j);
                            }
                        } else {//非key列
                            if ($table.data('col-content') == currentContent) {
                                m++;
                                addRowspan();   // 上一行与当前行内容相同则col-rowspan累加, 保存新值
                            } else {
                                newRowspan();   // 上一行与当前行内容不同
                            }
                        }
                    }
                } else {// 指定内容
                    if (opts.rows.length > 0) {
                        if (opts.rows[0].length == undefined) {
                            for (var i = 0; i < opts.rows.length; i++) {
                                customRowspan(opts.rows[i], opts.rows.length);
                            }
                        } else {
                            for (var i = 0; i < opts.rows[rowIndex].length; i++) {
                                customRowspan(opts.rows[rowIndex][i], opts.rows[rowIndex].length);
                            }
                        }
                    }
                }

                function customRowspan(val, len) {
                    if (index == val) {
                        if ($table.data('col-content') == '') {
                            if (currentContent == '') {
                                currentContent = true;
                            }
                            $table.data('col-content', currentContent);
                            $td.attr('rowspan', len);
                        } else {
                            $td.hide();
                        }
                    }
                }
                function addRowspan() {
                    var rowspan = $table.data('col-rowspan') + 1;
                    $table.data('col-rowspan', rowspan);
                    // 值得注意的是 如果用了$td.remove()就会对其他列的处理造成影响
                    $td.hide();
                    // 最后一行的情况比较特殊一点
                    // 比如最后2行 td中的内容是一样的, 那么到最后一行就应该把此时的col-td里保存的td设置rowspan
                    if (++index == $table.data('trNum')) {
                        $table.data('col-td').attr('rowspan', $table.data('col-rowspan'));
                    }
                }
                function newRowspan() {
                    // col-rowspan默认为1, 如果统计出的col-rowspan没有变化, 不处理
                    if ($table.data('col-rowspan') != 1) {
                        $table.data('col-td').attr('rowspan', $table.data('col-rowspan'));
                    }
                    // 保存第一次出现不同内容的td, 和其内容, 重置col-rowspan
                    $table.data('col-td', $td);
                    $table.data('col-content', $td.html());
                    $table.data('col-rowspan', 1);
                }
            });
        }
        // 同样是个private函数 清理内存之用
        function dispose($table) {
            $table.removeData();
        }
    };

})(jQuery);
//144