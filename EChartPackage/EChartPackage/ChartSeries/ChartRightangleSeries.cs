namespace EChartPackage.ChartSeries
{
    /// <summary>
    /// series（直角系）
    /// 驱动图表生成的数据内容数组 
    /// </summary>
    public class ChartRightangleSeries : ChartComSeries
    {
        /// <summary>
        /// 默认值：null
        /// 适用类型:折线图，柱状图 
        /// 组合名称，双数值轴时无效，多组数据的堆积图时使用，eg：stack:'group1'，则series数组中stack值等于'group1'的数据做堆积计算 
        /// </summary>
        public object stack { get; set; }

        /// <summary>
        /// 默认值：0
        /// 适用类型:折线图，柱状图，散点图 ，K线图
        ///xAxis坐标轴数组的索引，指定该系列数据所用的横坐标轴
        /// </summary>
        public object xAxisIndex { get; set; }

        /// <summary>
        /// 默认值：0
        /// 适用类型:折线图，柱状图，散点图 ，K线图
        /// yAxis坐标轴数组的索引，指定该系列数据所用的纵坐标轴 
        /// </summary>
        public object yAxisIndex { get; set; }

        /// <summary>
        /// 默认值：'30%'
        /// 适用类型:柱状图
        /// 柱间距离，默认为柱形宽度的30%，可设固定值 
        /// </summary>
        public object barGap { get; set; }

        /// <summary>
        /// 默认值：'20%'
        /// 适用类型:柱状图
        /// 类目间柱形距离，默认为类目间距的20%，可设固定值 
        /// </summary>
        public object barCategoryGap { get; set; }

        /// <summary>
        /// 默认值：0
        /// 适用类型:柱状图
        /// 柱条最小高度，可用于防止某item的值过小而影响交互 
        /// </summary>
        public object barMinHeight { get; set; }

        /// <summary>
        /// 默认值：自适应
        /// 适用类型:柱状图 ，K线图
        /// 柱条（K线蜡烛）宽度，不设时自适应 
        /// </summary>
        public object barWidth { get; set; }

        /// <summary>
        /// 默认值：自适应
        /// 适用类型:柱状图 ，K线图
        /// 柱条（K线蜡烛）最大宽度，不设时自适应 
        /// </summary>
        public object barMaxWidth { get; set; }

        /// <summary>
        /// 默认值：null
        /// 标志图形类型，默认自动选择（8种类型循环使用，不显示标志图形可设为'none'），默认循环选择类型有：
        ///'circle' | 'rectangle' | 'triangle' | 'diamond' |
        ///'emptyCircle' | 'emptyRectangle' | 'emptyTriangle' | 'emptyDiamond'
        ///另外，还支持五种更特别的标志图形'heart'（心形）、'droplet'（水滴）、'pin'（标注）、'arrow'（箭头）和'star'（五角星），这并不出现在常规的8类图形中，但无论是在系列级还是数据级上你都可以指定使用，同时，'star' + n（n>=3)可变化出N角星，如指定为'star6'则可以显示6角星
        ///自1.3.5起支持symbol为自定义图片，格式为'image://' + '图片路径'， 如'image://../asset/ico/favicon.png' 
        /// </summary>
        public object symbol { get; set; }

        /// <summary>
        /// 默认值：2 | 4
        /// 适用类型:折线图 (2)，散点图(4) 
        /// 标志图形大小，可计算特性启用情况建议增大以提高交互体验。实现气泡图时symbolSize需为Function，气泡大小取决于该方法返回值，传入参数为当前数据项（value数组）
        /// </summary>
        public object symbolSize { get; set; }

        /// <summary>
        /// 默认值：null
        /// 适用类型:折线图 ，散点图
        /// 标志图形旋转角度[-180,180]
        /// </summary>
        public object symbolRotate { get; set; }

        /// <summary>
        /// 默认值：false
        /// 适用类型:折线图
        /// 标志图形默认只有主轴显示（随主轴标签间隔隐藏策略），如需全部显示可把showAllSymbol设为true
        /// </summary>
        public object showAllSymbol { get; set; }

        /// <summary>
        /// 默认值：false
        /// 适用类型:折线图
        /// 平滑曲线显示，smooth为true时lineStyle不支持虚线
        /// </summary>
        public object smooth { get; set; }

        /// <summary>
        /// 默认值：'nearst'
        /// 适用类型:折线图
        /// ECharts 会在折线图的数据数量大于实际显示的像素宽度（高度）的时候会启用优化，对显示在一个像素宽度内的数据做筛选，该选项是指明数据筛选的策略。
        ///可选 'nearest', 'min', 'max', 'average'。或者是使用自定义的筛选函数
        /// </summary>
        public object dataFilter { get; set; }

        /// <summary>
        /// 默认值：false
        /// 适用类型:散点图
        /// 启动大规模散点图
        /// </summary>
        public object large { get; set; }

        /// <summary>
        /// 默认值：2000
        /// 适用类型:散点图
        /// 大规模散点图自动切换阀值，large为true下有效
        /// </summary>
        public object largeThreshold { get; set; }

        /// <summary>
        /// 默认值：true
        /// 适用类型:折线图，柱状图，散点图 
        /// 是否启用图例（legend）hover时的联动响应（高亮显示）
        /// </summary>
        public object legendHoverLink { get; set; }
    }
}