using System.Collections.Generic;
using EChartPackage.ChartCommon;

namespace EChartPackage.ChartComponent
{
    /// <summary>
    /// 图例，每个图表最多仅有一个图例。
    /// </summary>
    public class ChartLegend
    {
        /// <summary>
        /// 默认值：true
        /// 显示策略，可选为：true（显示） | false（隐藏）
        /// </summary>
        public object show { get; set; }
        /// <summary>
        /// 默认值：0
        /// 一级层叠控制。每一个不同的zlevel将产生一个独立的canvas，相同zlevel的组件或图标将在同一个canvas上渲染。zlevel越高越靠顶层，canvas对象增多会消耗更多的内存和性能，并不建议设置过多的zlevel，大部分情况可以通过二级层叠控制z实现层叠控制。
        /// </summary>
        public object zlevel { get; set; }
        /// <summary>
        /// 默认值：4
        /// 二级层叠控制，同一个canvas（相同zlevel）上z越高约靠顶层。
        /// </summary>
        public object z { get; set; }
        /// <summary>
        /// 默认值：'horizontal'
        /// 布局方式，默认为水平布局，可选为：'horizontal' | 'vertical'
        /// </summary>
        public string orient { get; set; }
        /// <summary>
        /// 默认值：'center'
        /// 水平安放位置，默认为全图居中，可选为：'center' | 'left' | 'right' | {number}（x坐标，单位px）
        /// </summary>
        public object x { get; set; }
        /// <summary>
        /// 默认值：'top'
        /// 垂直安放位置，默认为全图顶端，可选为：'top' | 'bottom' | 'center' | {number}（y坐标，单位px）
        /// </summary>
        public object y { get; set; }
        /// <summary>
        /// 默认值：'rgba(0,0,0,0)'
        /// 图例背景颜色，默认透明
        /// </summary>
        public string backgroundColor { get; set; }
        /// <summary>
        /// 默认值：'#ccc'
        /// 图例边框颜色
        /// </summary>
        public string borderColor { get; set; }
        /// <summary>
        /// 默认值：0
        /// 图例边框线宽，单位px，默认为0（无边框）
        /// </summary>
        public object borderWidth { get; set; }
        /// <summary>
        /// 默认值：5
        /// 图例内边距，单位px，默认各方向内边距为5，接受数组分别设定上右下左边距，同css，见下图
        /// </summary>
        public object padding { get; set; }
        /// <summary>
        /// 默认值：10
        /// 各个item之间的间隔，单位px，默认为10，横向布局时为水平间隔，纵向布局时为纵向间隔，见下图
        /// </summary>
        public object itemGap { get; set; }
        /// <summary>
        /// 默认值：20
        /// 图例图形宽度
        /// </summary>
        public object itemWidth { get; set; }
        /// <summary>
        /// 默认值：14
        /// 图例图形高度
        /// </summary>
        public object itemHeight { get; set; }
        /// <summary>
        /// 默认值：{color: '#333'}
        /// 默认只设定了图例文字颜色（详见textStyle） ，更个性化的是，要指定文字颜色跟随图例，可设color为'auto'
        /// </summary>
        public ChartTextStyle textStyle { get; set; }
        /// <summary>
        /// 默认值：null
        /// 文本格式器：{string}（Template） | {Function}，模板变量为'{name}'，函数回调参数为name
        /// </summary>
        public object formatter { get; set; }
        /// <summary>
        /// 默认值：true
        /// 选择模式，默认开启图例开关，可选single，multiple
        /// </summary>
        public object selectedMode { get; set; }
        /// <summary>
        /// 默认值：null
        /// 配置默认选中状态，可配合LEGEND.SELECTED事件做动态数据载入
        /// </summary>
        public object selected { get; set; }

        /// <summary>
        /// 默认值：[ ]
        /// 图例内容数组,数组项通常为{string}，每一项代表一个系列的name，默认布局到达边缘会自动分行（列），传入空字符串''可实现手动分行（列）。 
        /// </summary>
        public List<string> data { get; set; }

        /// <summary>
        /// 默认值：[ ]
        /// 图例内容数组，数组项通常为{string}，每一项代表一个系列的name，默认布局到达边缘会自动分行（列），传入空字符串''可实现手动分行（列）。 
        /// 使用根据该值索引series中同名系列所用的图表类型和itemStyle，如果索引不到，该item将默认为没启用状态。 
        /// 如需个性化图例文字样式，可把数组项改为{Object}，指定文本样式和个性化图例icon，格式为 
        /// {
        ///   name : {string}, 
        ///   textStyle : {Object}, 
        ///   icon : {string}
        /// }
        /// </summary>
        public List<LegendData> LegendDatas { get; set; }
       
    }

    /// <summary>
    /// 图例内容数组
    /// </summary>
    public class LegendData
    {
        /// <summary>
        /// 每一项代表一个系列的name，默认布局到达边缘会自动分行（列），传入空字符串''可实现手动分行（列）
        /// </summary>
        public string name { get; set; }
        /// <summary>
        ///（详见 textStyle）
        /// </summary>
        public ChartTextStyle textStyle { get; set; }
        /// <summary>
        /// 指定文本样式和个性化图例icon
        /// </summary>
        public string icon { get; set; }
    }
}
