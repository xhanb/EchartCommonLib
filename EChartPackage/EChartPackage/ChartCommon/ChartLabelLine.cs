namespace EChartPackage.ChartCommon
{
    /// <summary>
    /// 标签视觉引导线
    /// </summary>
   public class ChartLabelLine
    {
        /// <summary>
        /// 默认值：true
        /// 饼图标签视觉引导线显示策略，可选为：true（显示） | false（隐藏） 
        /// </summary>
        public object show { get; set; }

        /// <summary>
        /// 默认值：40
        /// 线长 ，从图形外边缘起计算，可为负值。漏斗图支持'auto'
        /// </summary>
        public object length { get; set; }

        /// <summary>
        /// 默认值：各异
        /// 线条样式，详见lineStyle
        /// </summary>
        public ChartTextStyle textStyle { get; set; }
    }
}
