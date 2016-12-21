using System.Collections.Generic;
using EChartPackage.ChartCommon;

namespace EChartPackage.ChartComponent
{
    /// <summary>
    /// 时间轴，每个图表最多仅有一个时间轴控件
    /// </summary>
    public class ChartTimeline : ChartCom
    {
        /// <summary>
        /// 默认值: true
        /// 显示策略，可选为：true（显示） | false（隐藏）
        /// </summary>
        public object show { get; set; }
        /// <summary>
        /// 默认值: 0
        /// 一级层叠控制。每一个不同的zlevel将产生一个独立的canvas，相同zlevel的组件或图标将在同一个canvas上渲染。zlevel越高越靠顶层，canvas对象增多会消耗更多的内存和性能，并不建议设置过多的zlevel，大部分情况可以通过二级层叠控制z实现层叠控制。
        /// </summary>
        public object zlevel { get; set; }
        /// <summary>
        /// 默认值: 4
        /// 二级层叠控制，同一个canvas（相同zlevel）上z越高约靠顶层。
        /// </summary>
        public object z { get; set; }
        /// <summary>
        /// 默认值: 'time'
        /// 模式是时间类型，时间轴间隔根据时间跨度自动计算，可选为：'number'
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 默认值: false
        /// 时间轴上多个option切换时是否进行merge操作，同setOption第二个参数
        /// </summary>
        public object notMerge { get; set; }
        /// <summary>
        /// 默认值: 80
        /// 时间轴左上角横坐标，数值单位px，支持百分比（字符串），如'50%'(显示区域横向中心)
        /// </summary>
        public object x { get; set; }
        /// <summary>
        /// 默认值: null
        /// 时间轴左上角纵坐标，数值单位px，支持百分比（字符串），默认无，随y2定位，如'50%'(显示区域纵向中心)
        /// </summary>
        public object y { get; set; }
        /// <summary>
        /// 默认值: 80
        /// 时间轴右下角横坐标，数值单位px，支持百分比（字符串），如'50%'(显示区域横向中心)
        /// </summary>
        public object x2 { get; set; }
        /// <summary>
        /// 默认值: 0
        /// 时间轴右下角纵坐标，数值单位px，支持百分比（字符串），如'50%'(显示区域纵向中心)
        /// </summary>
        public object y2 { get; set; }
        /// <summary>
        /// 默认值: 自适应
        /// 时间轴宽度，默认为总宽度 - x - x2，数值单位px，指定width后将忽略x2。见下图。 支持百分比（字符串），如'50%'(显示区域一半的宽度)
        /// </summary>
        public object width { get; set; }
        /// <summary>
        /// 默认值: 自适应
        /// 时间轴高度，数值单位px，支持百分比（字符串），如'50%'(显示区域一半的高度)
        /// </summary>
        public object height { get; set; }
        /// <summary>
        /// 默认值: 'rgba(0,0,0,0)'
        /// 背景颜色，默认透明。
        /// </summary>
        public string backgroundColor { get; set; }
        /// <summary>
        /// 默认值: 0
        /// 边框线宽
        /// </summary>
        public object borderWidth { get; set; }
        /// <summary>
        /// 默认值: '#ccc'
        /// 边框颜色。
        /// </summary>
        public string borderColor { get; set; }
        /// <summary>
        /// 默认值: 5
        /// 内边距，单位px，默认各方向内边距为5，接受数组分别设定上右下左边距，同css，见下图
        /// </summary>
        public object padding { get; set; }
        /// <summary>
        /// 默认值: 'left'
        /// 播放控制器位置，可选为：'left' | 'right' | 'none'
        /// </summary>
        public string controlPosition { get; set; }
        /// <summary>
        /// 默认值: false
        /// 是否自动播放
        /// </summary>
        public object autoPlay { get; set; }
        /// <summary>
        /// 默认值: true
        /// 是否循环播放
        /// </summary>
        public object loop { get; set; }
        /// <summary>
        /// 默认值: 2000
        /// 播放时间间隔，单位ms
        /// </summary>
        public object playInterval { get; set; }
        /// <summary>
        /// 默认值: {
        ///    color: '#666',
        ///    width: 1,
        ///    type: 'dashed'
        /// }   
        /// 时间轴轴线样式，lineStyle控制线条样式
        /// </summary>
        public ChartLineStyle lineStyle { get; set; }
        /// <summary>
        ///默认值: {
        ///    show: true,
        ///    interval: 'auto',
        ///    rotate: 0,
        ///    formatter: null,
        ///    textStyle: {
        ///        color: '#333'
        ///    }
        ///}
        ///时间轴标签文本
        ///show : 是否显示 
        ///interval : 挑选间隔，默认为'auto'，可选为：'auto'（自动隐藏显示不下的） | 0（全部显示） | {number} 
        ///rotate : 旋转角度，默认为0，不旋转，正值为逆时针，负值为顺时针，可选为：-90 ~ 90 
        ///formatter ： 间隔名称格式器：{string}（Template） | {Function} 
        ///textStyle : 文字样式
        /// </summary>
        public ChartLabel label { get; set; }
        /// <summary>
        /// 默认值: {
        ///     symbol : 'auto',
        ///     symbolSize : 'auto',
        ///     color : 'auto',
        ///     borderColor : 'auto',
        ///     borderWidth : 'auto',
        ///     label: {
        ///         show: false,
        ///         textStyle: {
        ///             color: 'auto'
        ///         }
        ///     }
        /// }         
        /// 时间轴当前点
        ///symbol : 当前点symbol，默认随轴上的symbol 
        ///symbolSize : 当前点symbol大小，默认随轴上symbol大小 
        ///color : 当前点symbol颜色，默认为随当前点颜色，可指定具体颜色，如无则为'#1e90ff' 
        ///borderColor ： 当前点symbol边线颜色 
        ///borderWidth ： 当前点symbol边线宽度 
        ///label同上
        /// </summary>
        public CheckpointStyle checkpointStyle { get; set; }
        /// <summary>
        /// 默认值: {
        ///    itemSize: 15,
        ///    itemGap: 5,
        ///    normal : {
        ///        color : '#333'
        ///    },
        ///    emphasis : {
        ///        color : '#1e90ff'
        ///    }
        /// }    
        /// 时间轴控制器样式，可指定itemSize按钮大小，itemGap按钮间隔，normal.color正常和emphasis.color高亮颜色
        /// </summary>
        public ControlStyle controlStyle { get; set; }
        /// <summary>
        /// 默认值: 'emptyDiamond'
        /// 轴点symbol，同serie.symbol
        /// </summary>
        public string symbol { get; set; }
        /// <summary>
        /// 默认值: 4
        /// 轴点symbol，同serie.symbolSize
        /// </summary>
        public object symbolSize { get; set; }
        /// <summary>
        /// 默认值: 0
        /// 当前索引位置，对应options数组，用于指定显示特定系列
        /// </summary>
        public object currentIndex { get; set; }
        /// <summary>
        /// 默认值: []
        /// 时间轴列表，同时也是轴label内容
        /// </summary>
        public  List<object> data { get; set; }
    }
    /// <summary>
    /// 时间轴当前点
    /// </summary>
    public class CheckpointStyle
    {
        /// <summary>
        /// symbol : 当前点symbol，默认随轴上的symbol 
        /// </summary>
        public string symbol { get; set; }
        /// <summary>
        /// symbolSize : 当前点symbol大小，默认随轴上symbol大小
        /// </summary>
        public string symbolSize { get; set; }
        /// <summary>
        /// color : 当前点symbol颜色，默认为随当前点颜色，可指定具体颜色，如无则为'#1e90ff' 
        /// </summary>
        public string color { get; set; }
        /// <summary>
        /// borderColor ： 当前点symbol边线颜色 
        /// </summary>
        public string borderColor { get; set; }
        /// <summary>
        /// borderWidth ： 当前点symbol边线宽度 
        /// </summary>
        public string borderWidth { get; set; }
        /// <summary>
        /// （相见 label ） 
        /// </summary>
        public ChartLabel label { get; set; }
    }
    /// <summary>
    /// 时间轴控制器样式
    /// </summary>
    public class ControlStyle
    {
        /// <summary>
        /// 可指定itemSize按钮大小
        /// </summary>
        public object itemSize { get; set; }
        /// <summary>
        /// itemGap按钮间隔
        /// </summary>
        public object itemGap { get; set; }
        /// <summary>
        /// normal.color正常
        /// </summary>
        public colors normal { get; set; }
        /// <summary>
        /// emphasis.color高亮颜色
        /// </summary>
        public colors emphasis { get; set; }
    }

    /// <summary>
    /// 颜色
    /// </summary>
    public class colors
    {
        /// <summary>
        /// 颜色值
        /// </summary>
        public string color { get; set; }
    }
}
