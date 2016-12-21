
using EChartPackage.ChartComponent;

namespace EChartPackage.ChartSeries
{
    /// <summary>
    /// 仪表盘
    /// 驱动图表生成的数据内容数组
    /// </summary>
   public class ChartGanGeSeries:ChartComSeries
    {
        /// <summary>
        /// 默认值：['50%', '50%'] 
        /// 圆心坐标，支持绝对值（px）和百分比，百分比计算min(width, height) * 50% 
        /// </summary>
        public object center { get; set; }

        /// <summary>
        /// 默认值：[0, '75%'] 
        /// 半径，支持绝对值（px）和百分比，百分比计算比，min(width, height) / 2 * 75%， 传数组实现环形图，[内半径，外半径] 
        /// </summary>
        public object radius { get; set; }

        /// <summary>
        /// 默认值：90
        /// 开始角度, 饼图（90）、仪表盘（225），有效输入范围：[-360,360]
        /// </summary>
        public object startAngle { get; set; }

        /// <summary>
        /// 默认值：0
        /// 最小角度，可用于防止某item的值过小而影响交互 
        /// </summary>
        public object endAngle { get; set; }

       /// <summary>
       /// 指定的最小值
       /// </summary>
        public object min { get; set; }
       /// <summary>
       /// 指定的最大值
       /// </summary>
        public object max { get; set; }
       /// <summary>
       /// 分割段数，默认为10
       /// </summary>
        public object splitNumber { get; set; }

        /// <summary>
        /// 坐标轴线，默认显示
        /// </summary>
        public AxisLine axisLine { get; set; }

        /// <summary>
        /// 坐标轴小标记，默认显示
        /// </summary>
        public AxisTick axisTick { get; set; }

        /// <summary>
        /// 坐标轴文本标签
        /// </summary>
        public AxisLabel axisLabel { get; set; }
       /// <summary>
       /// 指针样式
       /// </summary>
        public object pointer { get; set; }
       /// <summary>
       /// 仪表盘详情
       /// </summary>
        public object detail { get; set; }
       /// <summary>
       /// 仪表盘标题
       /// </summary>
        public ChartTitle title { get; set; }

       /// <summary>
       /// 主分割线，默认显示
       /// </summary>
        public SplitLine splitLine { get; set; }
    }
}
