using EChartPackage.ChartCommon;

namespace EChartPackage.ChartComponent
{
    /// <summary>
    /// 值域选择，每个图表最多仅有一个值域控件。
    /// </summary>
    public class ChartDataRange
    {
        /// <summary>
        /// 默认值：true
        /// 显示策略，可选为：true（显示） | false（隐藏）
        /// </summary>
        public bool show { get; set; }
        /// <summary>
        /// 默认值：0
        /// 一级层叠控制。每一个不同的zlevel将产生一个独立的canvas，相同zlevel的组件或图标将在同一个canvas上渲染。zlevel越高越靠顶层，canvas对象增多会消耗更多的内存和性能，并不建议设置过多的zlevel，大部分情况可以通过二级层叠控制z实现层叠控制。
        /// </summary>
        public int zlevel { get; set; }
        /// <summary>
        /// 默认值：4	
        /// 二级层叠控制，同一个canvas（相同zlevel）上z越高约靠顶层。
        /// </summary>
        public int z { get; set; }
        /// <summary>
        /// 默认值：'vertical'
        /// 布局方式，默认为垂直布局，可选为：'horizontal' | 'vertical'
        /// </summary>
        public string orient { get; set; }
        /// <summary>
        /// 默认值：'left'
        /// 水平安放位置，默认为全图左对齐，可选为：'center' | 'left' | 'right' | {number}（x坐标，单位px）
        /// </summary>
        public object x { get; set; }
        /// <summary>
        /// 默认值：'bottom'
        /// 垂直安放位置，默认为全图底部，可选为：'top' | 'bottom' | 'center' | {number}（y坐标，单位px）
        /// </summary>
        public object y { get; set; }
        /// <summary>
        /// 默认值：'rgba(0,0,0,0)'
        /// 值域控件背景颜色，默认透明
        /// </summary>
        public string backgroundColor { get; set; }
        /// <summary>
        /// 默认值：'#ccc'
        /// 值域控件边框颜色
        /// </summary>
        public string borderColor { get; set; }
        /// <summary>
        /// 默认值：0
        /// 值域控件边框线宽，单位px，默认为0（无边框）
        /// </summary>
        public int borderWidth { get; set; }
        /// <summary>
        /// 默认值：5
        /// 值域控件内边距，单位px，默认各方向内边距为5，接受数组分别设定上右下左边距，同css
        /// </summary>
        public object padding { get; set; }
        /// <summary>
        /// 默认值：10
        /// 各个item之间的间隔，单位px，默认为10，横向布局时为水平间隔，纵向布局时为纵向间隔
        /// </summary>
        public int itemGap { get; set; }
        /// <summary>
        /// 默认值：20
        /// 值域控件图形宽度
        /// </summary>
        public int itemWidth { get; set; }
        /// <summary>
        /// 默认值：14
        /// 值域控件图形高度
        /// </summary>
        public int itemHeight { get; set; }
        /// <summary>
        /// 默认值：null
        /// 指定的最小值，eg: 0，默认无，必须参数
        /// </summary>
        public int min { get; set; }
        /// <summary>
        /// 默认值：null
        /// 指定的最大值，eg: 100，默认无，必须参数
        /// </summary>
        public int max { get; set; }
        /// <summary>
        /// 默认值：0	
        /// 小数精度，默认为0，无小数点，当 min ~ max 间在当前精度下无法整除splitNumber份时，精度会自动提高以满足均分，不支持不等划分
        /// </summary>
        public int precision { get; set; }
        /// <summary>
        /// 默认值：5
        /// 分割段数，默认为5，为0时为线性渐变，calculable为true是默认均分100份
        /// </summary>
        public int splitNumber { get; set; }
        /// <summary>
        /// 默认值：true
        /// 选择模式，默认开启值域开关，可选single，multiple
        /// </summary>
        public object selectedMode { get; set; }
        /// <summary>
        /// 默认值：false
        /// 是否启用值域漫游，启用后无视splitNumber，值域显示为线性渐变
        /// </summary>
        public bool calculable { get; set; }
        /// <summary>
        /// 默认值：true
        /// 是否启用地图hover时的联动响应（详情披露）
        /// </summary>
        public bool hoverLink { get; set; }
        /// <summary>
        /// 默认值：true
        /// 值域漫游是否实时显示，在不支持Canvas的浏览器中该值自动强制置为false。
        /// </summary>
        public bool realtime { get; set; }
        /// <summary>
        /// 默认值：['#1e90ff','#f0ffff']
        /// 值域颜色标识，颜色数组长度必须>=2，颜色代表从数值高到低的变化，即颜色数组低位代表数值高的颜色标识 ，支持Alpha通道上的变化（rgba）
        /// </summary>
        public string[] color { get; set; }
        /// <summary>
        /// 默认值：null
        /// 内容格式器：{string}（Template） | {Function}，模板变量为'{value}'和'{value2}'，代表数值起始值和结束值，函数参数两个，含义同模板变量，当calculable为true时模板变量仅有'{value}'
        /// </summary>
        public object formatter { get; set; }
        /// <summary>
        /// 默认值：null
        /// 值域文字显示，splitNumber生效时默认以计算所得数值作为值域文字显示，可指定长度为2的文本数组显示简介的值域文本，如['高', '低']，'\n'指定换行
        /// </summary>
        public string[] text { get; set; }
        /// <summary>
        /// 默认值：{color: '#333'}
        /// （详见textStyle）默认只设定了值域控件文字颜色
        /// </summary>
        public ChartTextStyle textStyle { get; set; }
    }
}
