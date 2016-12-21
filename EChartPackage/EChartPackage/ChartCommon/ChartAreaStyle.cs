namespace EChartPackage.ChartCommon
{
    /// <summary>
    /// 区域填充样式
    /// </summary>
   public class ChartAreaStyle
    {
        /// <summary>
        /// 默认值：各异
        /// 颜色
        /// </summary>
        public string color { get; set; }

        /// <summary>
        /// 默认值：'default' 
        /// 填充样式，目前仅支持'default'(实填充) 
        /// </summary>
        public string type { get; set; }
    }
}
