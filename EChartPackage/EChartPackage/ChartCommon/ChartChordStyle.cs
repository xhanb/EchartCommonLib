namespace EChartPackage.ChartCommon
{
    /// <summary>
    /// 和弦图中的弦样式 
    /// </summary>
    public class ChartChordStyle
    {
        /// <summary>
        /// 默认值：1
        /// 贝塞尔曲线的线宽, ribbonType是false时有效
        /// </summary>
        public string width { get; set; }

        /// <summary>
        /// 默认值：1
        /// 贝塞尔曲线的颜色, ribbonType是false时有效
        /// </summary>
        public string color { get; set; }

        /// <summary>
        /// 默认值：1
        /// ribbon的描边线宽, ribbonType是true时有效
        /// </summary>
        public string borderWidth { get; set; }

        /// <summary>
        /// 默认值：1
        /// ribbon的描边颜色, ribbonType是true时有效
        /// </summary>
        public string borderColor { get; set; }
    }
}
