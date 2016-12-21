namespace EChartPackage.ChartCommon
{
    /// <summary>
    /// 标签
    /// </summary>
    public class ChartLabel
    {
        /// <summary>
        /// 默认值：true
        /// 标签显示策略，可选为：true（显示） | false（隐藏） 
        /// </summary>
        public object show { get; set; }

        /// <summary>
        /// 默认值：'outer' | null
        /// 标签显示位置，地图标签不可指定位置
        /// 饼图可选为：'outer'（外部） | 'inner'（内部），
        /// 漏斗图可选为：'inner'（内部）| 'left' | 'right'（默认），
        /// 折线图，柱形图，K线图，散点图默认根据布局自适应为'top'或者'right'，可选的还有：'inside' | 'left' | 'bottom'
        /// 柱形图可选的还有，'insideLeft' | 'insideRight' | 'insideTop' | 'insideBottom' 
        /// </summary>
        public string position { get; set; }

        /// <summary>
        /// 默认值：false
        /// 和弦图有效，文本标签自动旋转
        /// </summary>
        public object rotate { get; set; }

        /// <summary>
        /// 默认值：10
        /// 和弦图: 文本标签旋转后于弦的间隔
        ///饼图: 当label position为inner时有效，为label位置到圆心的距离与圆半径(环状图为内外半径和)的比例系数，默认为0.5。 
        /// </summary>
        public object distance { get; set; }

        /// <summary>
        /// 默认值：null
        /// 标签文本格式器，通用，同Tooltip.formatter，支持模板、方法回调，不支持异步回调
        /// </summary>
        public object formatter { get; set; }

        /// <summary>
        /// 默认值：null
        /// 标签的文本样式（详见textStyle） 
        /// </summary>
        public ChartTextStyle textStyle { get; set; }
    }
}
