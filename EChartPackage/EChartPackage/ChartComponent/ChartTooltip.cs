using EChartPackage.ChartCommon;

namespace EChartPackage.ChartComponent
{
    /// <summary>
    /// 提示框，鼠标悬浮交互时的信息提示。
    /// </summary>
    public class ChartTooltip
    {
        /// <summary>
        /// 默认值：true
        /// 显示策略，可选为：true（显示） | false（隐藏）
        /// </summary>
        public object show { get; set; }
        /// <summary>
        /// 默认值：1
        /// 一级层叠控制。每一个不同的zlevel将产生一个独立的canvas，相同zlevel的组件或图标将在同一个canvas上渲染。zlevel越高越靠顶层，canvas对象增多会消耗更多的内存和性能，并不建议设置过多的zlevel，大部分情况可以通过二级层叠控制z实现层叠控制。
        /// </summary>
        public object zlevel { get; set; }
        /// <summary>
        /// 默认值：8
        /// 二级层叠控制，同一个canvas（相同zlevel）上z越高约靠顶层。
        /// </summary>
        public object z { get; set; }
        /// <summary>
        /// 默认值：true
        /// tooltip主体内容显示策略，只需tooltip触发事件或显示axisPointer而不需要显示内容时可配置该项为false，可选为：true（显示） | false（隐藏）
        /// </summary>
        public object showContent { get; set; }
        /// <summary>
        /// 默认值：'item'
        /// 发类型，默认数据触发，见下图，可选为：'item' | 'axis'
        /// </summary>
        public string trigger { get; set; }
        /// <summary>
        /// 默认值：null
        /// 位置指定，传入{Array}，如[x, y]， 固定位置[x, y]；传入{Function}，如function([x, y]) {return [newX,newY]}，默认显示坐标为输入参数，用户指定的新坐标为输出返回。
        /// </summary>
        public object position { get; set; }
        /// <summary>
        /// 默认值：null
        /// 内容格式器：{string}（Template） | {Function}，支持异步回调见表格下方
        /// </summary>
        public object formatter { get; set; }
        /// <summary>
        /// 默认值：'{a} < br/>{b} : {c}'
        /// 拖拽重计算独有，数据孤岛内容格式器：{string}（Template） | {Function}，见表格下方
        /// </summary>
        public object islandFormatter { get; set; }
        /// <summary>
        /// 默认值：20
        /// 显示延迟，添加显示延迟可以避免频繁切换，特别是在详情内容需要异步获取的场景，单位ms
        /// </summary>
        public object showDelay { get; set; }
        /// <summary>
        /// 默认值：100
        /// 隐藏延迟，单位ms
        /// </summary>
        public object hideDelay { get; set; }
        /// <summary>
        /// 默认值：0.4
        /// 动画变换时长，单位s，如果你希望tooltip的跟随实时响应，showDelay设置为0是关键，同时transitionDuration设0也会有交互体验上的差别。
        /// </summary>
        public object transitionDuration { get; set; }
        /// <summary>
        /// 默认值：false
        /// 鼠标是否可进入详情气泡中，默认为false，如需详情内交互，如添加链接，按钮，可设置为true。
        /// </summary>
        public object enterable { get; set; }
        /// <summary>
        /// 默认值：'rgba(0,0,0,0.7)'
        /// 提示背景颜色，默认为透明度为0.7的黑色
        /// </summary>
        public string backgroundColor { get; set; }
        /// <summary>
        /// 默认值：'#333'
        /// 提示边框颜色
        /// </summary>
        public string borderColor { get; set; }
        /// <summary>
        /// 默认值：4
        /// 提示边框圆角，单位px，默认为4
        /// </summary>
        public object borderRadius { get; set; }
        /// <summary>
        /// 默认值：0
        /// 提示边框线宽，单位px，默认为0（无边框）
        /// </summary>
        public object borderWidth { get; set; }
        /// <summary>
        /// 默认值：5
        /// 提示内边距，单位px，默认各方向内边距为5，接受数组分别设定上右下左边距，同css
        /// </summary>
        public object padding { get; set; }
        /// <summary>
        /// 默认值：{
        ///     type: 'line',
        ///     lineStyle: {
        ///         color: '#48b',
        ///         width: 2,
        ///         type: 'solid'
        ///     },
        ///     crossStyle: {
        ///         color: '#1e90ff',
        ///         width: 1,
        ///         type: 'dashed'
        ///     },
        ///     shadowStyle: {
        ///         color: 'rgba(150,150,150,0.3)',
        ///         width: 'auto',
        ///         type: 'default'
        ///     }
        /// }
        /// 坐标轴指示器，默认type为line，可选为：'line' | 'cross' | 'shadow' | 'none'(无)，指定type后对应style生效，见下 
        /// lineStyle设置直线指示器（详见lineStyle）, 
        /// crossStyle设置十字准星指示器（详见lineStyle）, 
        /// shadowStyle设置阴影指示器（详见areaStyle），areaStyle.size默认为'auto'自动计算，可指定具体宽度
        /// </summary>
        public AxisPointer axisPointer { get; set; }
        /// <summary>
        /// 默认值：{ color:'#fff' }
        /// 文本样式，默认为白色字体（详见textStyle）
        /// </summary>
        public ChartTextStyle textStyle { get; set; }
    }
    /// <summary>
    /// 坐标轴指示器
    /// </summary>
    public class AxisPointer
    {
        /// <summary>
        /// 默认type为line，可选为：'line' | 'cross' | 'shadow' | 'none'(无)，指定type后对应style生效
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// （详见lineStyle）lineStyle设置直线指示器
        /// </summary>
        public object lineStyle { get; set; }
        /// <summary>
        /// （详见lineStyle）crossStyle设置十字准星指示器
        /// </summary>
        public object crossStyle { get; set; }
        /// <summary>
        /// （详见areaStyle）shadowStyle设置阴影指示器，areaStyle.size默认为'auto'自动计算，可指定具体宽度
        /// </summary>
        public object shadowStyle { get; set; }
    }
}
