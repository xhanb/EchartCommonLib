namespace EChartPackage.ChartCommon
{
    /// <summary>
    /// 图形样式，可设置图表内图形的默认样式和强调样式
    /// </summary>
    public class ChartItemStyle
    {
        /// <summary>
        ///  默认样式
        /// </summary>
        public NormalStyle normal { get; set; }

        /// <summary>
        /// 强调样式
        /// </summary>
        public EmphasisStyle emphasis { get; set; }
    }

    /// <summary>
    /// 默认样式
    /// </summary>
    public class NormalStyle
    {
        /// <summary>
        /// 适用类型：通用
        /// 默认值：图表各异 
        /// 颜色，主色 ，函数回调参数为{seriesIndex:x, series:xxx, dataIndex:y, data:yyy}
        /// </summary>
        public object color { get; set; }

        /// <summary>
        /// 适用类型：折线图，K线图，markLine
        /// 默认值：图表各异 
        /// 线条样式，详见lineStyle
        /// </summary>
        public ChartLineStyle lineStyle { get; set; }

        /// <summary>
        /// 适用类型：堆积折线图，地图
        /// 默认值：图表各异 
        /// 区域样式，详见areaStyle
        /// </summary>
        public ChartAreaStyle areaStyle { get; set; }

        /// <summary>
        /// 适用类型：和弦图
        /// 默认值：图表各异 
        /// 弦样式，详见chordStyle
        /// </summary>
        public ChartChordStyle chordStyle { get; set; }

        /// <summary>
        /// 适用类型：力导向图
        /// 默认值：图表各异 
        /// 节点样式，详见nodeStyle
        /// </summary>
        public ChartNodeStyle nodeStyle { get; set; }

        /// <summary>
        /// 适用类型：力导向图
        /// 默认值：图表各异 
        /// 边样式，详见linkStyle
        /// </summary>
        public ChartLinkStyle linkStyle { get; set; }

        /// <summary>
        /// 适用类型：折线图（symbol），散点图（symbole），饼图，地图，markPoint
        /// 默认值：各异 
        /// 边框颜色
        /// </summary>
        public string borderColor { get; set; }

        /// <summary>
        /// 适用类型：折线图（symbol），散点图（symbole），饼图，地图，markPoint
        /// 默认值：各异 
        /// 边框线宽，单位px 
        /// </summary>
        public object borderWidth { get; set; }

        /// <summary>
        /// 适用类型：柱形图
        /// 默认值：'#fff'  
        /// 边框颜色
        /// </summary>
        public string barBorderColor { get; set; }

        /// <summary>
        /// 适用类型：柱形图
        /// 默认值：0
        /// 柱形边框圆角，单位px，默认为0，支持传入数组分别指定柱形4个圆角半径，如:[5, 5, 0, 0]（顺时针左上，右上，右下，左下） 
        /// </summary>
        public string[] barBorderRadius { get; set; }

        /// <summary>
        /// 适用类型：柱形图
        /// 默认值：0 
        /// 柱形边框线宽，单位px，默认为0 
        /// </summary>
        public object barBorderWidth { get; set; }

        /// <summary>
        /// 适用类型：折线图，柱形图，K线图，散点图，饼图 ，地图，力导向，漏斗图，markPoint，markLine
        /// 默认值:{show: true,position:'outer'}     
        /// 标签，饼图默认显示在外部，离饼图距离由labelLine.length决定，
        /// 漏斗图默认显示在右侧，离图形距离由labelLine.length决定
        /// 地图标签不可指定位置，
        /// 折线图，柱形图，K线图，散点图可指定position见下 
        /// </summary>
        public ChartLabel label { get; set; }

        /// <summary>
        /// 适用类型:饼图，漏斗图
        /// 默认值：{show: true} 
        /// 标签视觉引导线，默认显示
        /// </summary>
        public ChartLabelLine labelLine { get; set; }
    }

    /// <summary>
    /// 强调样式
    /// </summary>
    public class EmphasisStyle
    {
        /// <summary>
        /// 适用类型：通用
        /// 默认值：图表各异 
        /// 颜色，主色 ，函数回调参数为{seriesIndex:x, series:xxx, dataIndex:y, data:yyy}
        /// </summary>
        public object color { get; set; }

        /// <summary>
        /// 适用类型：折线图，K线图，markLine
        /// 默认值：图表各异 
        /// 线条样式，详见lineStyle
        /// </summary>
        public ChartLineStyle lineStyle { get; set; }

        /// <summary>
        /// 适用类型：堆积折线图，地图
        /// 默认值：图表各异 
        /// 区域样式，详见areaStyle
        /// </summary>
        public ChartAreaStyle areaStyle { get; set; }

        /// <summary>
        /// 适用类型：和弦图
        /// 默认值：图表各异 
        /// 弦样式，详见chordStyle
        /// </summary>
        public ChartChordStyle chordStyle { get; set; }

        /// <summary>
        /// 适用类型：力导向图
        /// 默认值：图表各异 
        /// 节点样式，详见nodeStyle
        /// </summary>
        public ChartNodeStyle nodeStyle { get; set; }

        /// <summary>
        /// 适用类型：力导向图
        /// 默认值：图表各异 
        /// 边样式，详见linkStyle
        /// </summary>
        public ChartLinkStyle linkStyle { get; set; }

        /// <summary>
        /// 适用类型：折线图（symbol），散点图（symbole），饼图，地图，markPoint
        /// 默认值：各异 
        /// 边框颜色
        /// </summary>
        public string borderColor { get; set; }

        /// <summary>
        /// 适用类型：折线图（symbol），散点图（symbole），饼图，地图，markPoint
        /// 默认值：各异 
        /// 边框线宽，单位px 
        /// </summary>
        public object borderWidth { get; set; }

        /// <summary>
        /// 适用类型：柱形图
        /// 默认值：'#fff'  
        /// 边框颜色
        /// </summary>
        public string barBorderColor { get; set; }

        /// <summary>
        /// 适用类型：柱形图
        /// 默认值：0
        /// 柱形边框圆角，单位px，默认为0，支持传入数组分别指定柱形4个圆角半径，如:[5, 5, 0, 0]（顺时针左上，右上，右下，左下） 
        /// </summary>
        public string[] barBorderRadius { get; set; }

        /// <summary>
        /// 适用类型：柱形图
        /// 默认值：0 
        /// 柱形边框线宽，单位px，默认为0 
        /// </summary>
        public object barBorderWidth { get; set; }

        /// <summary>
        /// 适用类型：折线图，柱形图，K线图，散点图，饼图 ，地图，力导向，漏斗图，markPoint，markLine
        /// 默认值:{show: true,position:'outer'}     
        /// 标签，饼图默认显示在外部，离饼图距离由labelLine.length决定，
        /// 漏斗图默认显示在右侧，离图形距离由labelLine.length决定
        /// 地图标签不可指定位置，
        /// 折线图，柱形图，K线图，散点图可指定position见下 
        /// </summary>
        public ChartLabel label { get; set; }

        /// <summary>
        /// 适用类型:饼图，漏斗图
        /// 默认值：{show: true} 
        /// 标签视觉引导线，默认显示
        /// </summary>
        public ChartLabelLine labelLine { get; set; }
    }
}
