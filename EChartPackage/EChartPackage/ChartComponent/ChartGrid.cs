namespace EChartPackage.ChartComponent
{
    /// <summary>
    /// 直角坐标系内绘图网格
    /// </summary>
    public class ChartGrid
    {
        /// <summary>
        /// 默认值：0
        /// 一级层叠控制。每一个不同的zlevel将产生一个独立的canvas，相同zlevel的组件或图标将在同一个canvas上渲染。zlevel越高越靠顶层，canvas对象增多会消耗更多的内存和性能，并不建议设置过多的zlevel，大部分情况可以通过二级层叠控制z实现层叠控制。
        /// </summary>
        public int zlevel { get; set; }
        /// <summary>
        /// 默认值：0
        /// 二级层叠控制，同一个canvas（相同zlevel）上z越高约靠顶层。
        /// </summary>
        public int z { get; set; }
        /// <summary>
        /// 默认值：80
        /// 直角坐标系内绘图网格左上角横坐标，数值单位px，支持百分比（字符串），如'50%'(显示区域横向中心)
        /// </summary>
        public object x { get; set; }
        /// <summary>
        /// 默认值：60
        /// 直角坐标系内绘图网格左上角纵坐标，数值单位px，支持百分比（字符串），如'50%'(显示区域纵向中心)
        /// </summary>
        public object y { get; set; }
        /// <summary>
        /// 默认值：80
        /// 直角坐标系内绘图网格右下角横坐标，数值单位px，支持百分比（字符串），如'50%'(显示区域横向中心)
        /// </summary>
        public object x2 { get; set; }
        /// <summary>
        /// 默认值：60
        /// 直角坐标系内绘图网格右下角纵坐标，数值单位px，支持百分比（字符串），如'50%'(显示区域纵向中心)
        /// </summary>
        public object y2 { get; set; }
        /// <summary>
        /// 默认值：自适应
        /// 直角坐标系内绘图网格（不含坐标轴）宽度，默认为总宽度 - x - x2，数值单位px，指定width后将忽略x2。
        /// 支持百分比（字符串），如'50%'(显示区域一半的宽度)
        /// </summary>
        public object width { get; set; }
        /// <summary>
        /// 默认值：自适应
        /// 直角坐标系内绘图网格（不含坐标轴）高度，默认为总高度 - y - y2，数值单位px，指定height后将忽略y2。 
        /// 支持百分比（字符串），如'50%'(显示区域一半的高度)
        /// </summary>
        public object height { get; set; }
        /// <summary>
        /// 默认值：'rgba(0,0,0,0)'
        /// 背景颜色，默认透明。
        /// </summary>
        public string backgroundColors { get; set; }
        /// <summary>
        /// 默认值：1
        /// 边框线宽
        /// </summary>
        public int borderWidth { get; set; }
        /// <summary>
        /// 默认值：'#ccc'
        /// 边框颜色。
        /// </summary>
        public string borderColor { get; set; }

        /// <summary>
        /// [Defalult:false]
        /// grid区域是否包含坐标轴的刻度标签，在无法确定坐标轴标签的宽度，容器有比较小无法预留较多空间的时候，可以设为true防止标签溢出容器。
        /// </summary>
        public object containLable { get; set; }
    }
}
