using EChartPackage.ChartCommon;

namespace EChartPackage.ChartComponent
{
    /// <summary>
    /// 标题，每个图表最多仅有一个标题控件，每个标题控件可设主副标题。
    /// </summary>
    public class ChartTitle
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
        /// 默认值：6
        /// 二级层叠控制，同一个canvas（相同zlevel）上z越高约靠顶层。
        /// </summary>
        public object z { get; set; }
        /// <summary>
        /// 默认值：''
        /// 主标题文本，'\n'指定换行
        /// </summary>
        public string text { get; set; }
        /// <summary>
        /// 默认值：''
        /// 主标题文本超链接
        /// </summary>
        public string link { get; set; }
        /// <summary>
        /// 默认值：null
        /// 指定窗口打开主标题超链接，支持'self' | 'blank'，不指定等同为'blank'（新窗口）
        /// </summary>
        public string target { get; set; }
        /// <summary>
        /// 默认值：''
        /// 副标题文本，'\n'指定换行
        /// </summary>
        public string subtext { get; set; }
        /// <summary>
        /// 默认值：''
        /// 副标题文本超链接
        /// </summary>
        public string sublink { get; set; }
        /// <summary>
        /// 默认值：null
        /// 指定窗口打开副标题超链接，支持'self' | 'blank'，不指定等同为'blank'（新窗口）
        /// </summary>
        public string subtarget { get; set; }
        /// <summary>
        /// 默认值：'left'
        /// 水平安放位置，默认为左侧，可选为：'center' | 'left' | 'right' | {number}（x坐标，单位px）
        /// </summary>
        public object x { get; set; }
        /// <summary>
        /// 默认值：'top'
        /// 垂直安放位置，默认为全图顶端，可选为：'top' | 'bottom' | 'center' | {number}（y坐标，单位px）
        /// </summary>
        public object y { get; set; }
        /// <summary>
        /// 默认值：null
        /// 水平对齐方式，默认根据x设置自动调整，可选为： left' | 'right' | 'center
        /// </summary>
        public string textAlign { get; set; }
        /// <summary>
        /// 默认值：'rgba(0,0,0,0)'
        /// 标题背景颜色，默认透明
        /// </summary>
        public string backgroundColor { get; set; }
        /// <summary>
        /// 默认值：'#ccc'
        /// 标题边框颜色
        /// </summary>
        public string borderColor { get; set; }
        /// <summary>
        /// 默认值：0
        /// 标题边框线宽，单位px，默认为0（无边框）
        /// </summary>
        public object borderWidth { get; set; }
        /// <summary>
        /// 默认值：5
        /// 标题内边距，单位px，默认各方向内边距为5，接受数组分别设定上右下左边距，同css，见下图
        /// </summary>
        public object padding { get; set; }
        /// <summary>
        /// 默认值：5
        /// 主副标题纵向间隔，单位px，默认为5
        /// </summary>
        public object itemGap { get; set; }
        /// <summary>
        /// 默认值：{
        ///     fontSize: 18,
        ///     fontWeight: 'bolder',
        ///     color: '#333'
        /// } 
        /// 主标题文本样式
        /// </summary>
        public ChartTextStyle textStyle { get; set; }
        /// <summary>
        /// 默认值：{
        ///     color: '#aaa'
        /// }  
        /// 副标题文本样式
        /// </summary>
        public ChartTextStyle subtextStyle { get; set; }

        /// <summary>
        /// 用于标题定位，数组为横纵相对仪表盘圆心坐标偏移，支持百分比（相对外半径）
        /// </summary>
        public object offsetCenter { get; set; }


    }
}
