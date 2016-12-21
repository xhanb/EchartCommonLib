namespace EChartPackage.ChartCommon
{
    /// <summary>
    /// 线条（线段）样式
    /// </summary>
    public class ChartLineStyle
    {
        /// <summary>
        /// 默认值：各异
        /// 颜色
        /// </summary>
        public string color { get; set; }

        /// <summary>
        /// 默认值：'solid' 
        /// 线条样式，可选为：'solid' | 'dotted' | 'dashed' 
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// 默认值：各异
        /// 线宽
        /// </summary>
        public object width { get; set; }

        /// <summary>
        /// 默认值：5
        /// 折线主线(IE8+)有效，阴影模糊度，大于0有效 
        /// </summary>
        public object shadowBlur { get; set; }

        /// <summary>
        /// 默认值：3
        /// 折线主线(IE8+)有效，阴影横向偏移，正值往右，负值往左 
        /// </summary>
        public object shadowOffsetX { get; set; }

        /// <summary>
        /// 默认值：3
        /// 折线主线(IE8+)有效，阴影纵向偏移，正值往下，负值往上 
        /// </summary>
        public object shadowOffsetY { get; set; }
    }
}
